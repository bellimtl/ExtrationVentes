using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Globalization;
using System.IO;

/// <summary>
/// @author Fabien Belli
/// </summary>
namespace ExtractionVente
{
    public partial class Prevision_des_ventes : Form
    {
        OracleConnection conn;

        // formulaire fils
        private Liste_produits myListeProduct;

        public Prevision_des_ventes()
        {
            InitializeComponent();

            string oradb = System.IO.File.ReadAllText(@"./tnsnames.ora");

            conn = new OracleConnection(oradb);

            try {
                conn.Open();
            } catch (Exception MonException) {
                MessageBox.Show("Connexion impossible a la base de données, veuillez verifier votre connexion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }


            // Initialisation de la combo
            //
            init_combo();
            init_table();
        }

        /// <summary>
        /// Initializing combo box
        /// </summary>
        private void init_combo()
        {

            string requeteSelectProducts = @"
                SELECT 
                    ITEM_NO 
                FROM 
                    SSFRANCE.ITEM
            ";

            OracleDataReader dr = execSQL(requeteSelectProducts);
         
            while (dr.Read())
            {
                string myItem = dr.GetString(0);
                comboProduits.Items.Add(myItem);
            }

            //timePickerDepart. = new DateTime(2001, 10, 20);
        }

        /// <summary>
        /// Return the OracleDateReader corresponding to the sql commande
        /// </summary>
        /// <param name="codeSQL">SQL code of the request</param>
        /// <returns>OracleDataReader needed</returns>
        private OracleDataReader execSQL(string codeSQL)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = codeSQL;
            cmd.CommandType = CommandType.Text;
            return cmd.ExecuteReader();
        }

        private void FermetureFenetre(object sender, FormClosedEventArgs e)
        {
            conn.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myListeProduct = new Liste_produits(this);
            myListeProduct.Show();
            myListeProduct.populateTable(conn);
        }

        /// <summary>
        /// Select product code
        /// </summary>
        /// <param name="codeProduit"></param>
        public void selectCombo(string codeProduit)
        {
            int index = comboProduits.FindString(codeProduit);
            comboProduits.SelectedIndex = index;
        }

        private void init_table()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("COL_A", "Années");
            for (int i = 0; i < 12; i++)
            {
                DateTime maDateParcours = new DateTime(2015,i+1,1);
                dataGridView1.Columns.Add("COL_"+i, maDateParcours.ToString("MMMM"));
            }
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void boutonCalculVente_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            // Vérification des données
            //
            string productCodeSelected = this.comboProduits.GetItemText(this.comboProduits.SelectedItem);
            if (productCodeSelected == "")
            {
                MessageBox.Show("Veuillez sélectionner un produit");
                return;
                //productCodeSelected = "KIL031";
            }

            string dateDepart = timePickerDepart.Value.Date.ToString("yyyyMMdd");
            string dateFin = timePicketFin.Value.Date.ToString("yyyyMMdd");


            // Gestion des commandes commandées et expediées
            //
            string sqlSelected = @"
                 AND
                    SOORDER_HD.STATUS_2 = '0'
            ";
           
            if (radioCommandeEtExperdiees.Checked)
            {
                sqlSelected = @"
                 AND
                    SOORDER_HD.STATUS_2 = '1'
                 AND
                    SOORDER_HD.STATUS_2 = '0'
                ";
            }

            sqlSelected = "";

            string marequeteSQL = @"
                SELECT 
                    ITEM.ITEM_NO AS codeProduit,
                    SUBSTR(SOORDER_DTL.LAST_MOD_DATE,4,6),
                    SUM(SOORDER_DTL.QTY_ORD) AS sommeQuantite,
                    SUBSTR(SOORDER_DTL.LAST_MOD_DATE, 8, 2)
                FROM    
                    SSFRANCE.ITEM, 
                    SSFRANCE.SOORDER_DTL,
                    SSFRANCE.SOORDER_HD
                WHERE
                    ITEM.ITEM_NO=SOORDER_DTL.ITEM_NO
                AND
                    SOORDER_DTL.SEQ_NO = SOORDER_HD.SEQ_NO
                AND
                    SOORDER_DTL.ITEM_NO = '" + productCodeSelected + @"'
                AND
                    SOORDER_DTL.LAST_MOD_DATE >= TO_DATE ('"+ dateDepart + @"', 'yyyymmdd')
                AND
                    SOORDER_DTL.LAST_MOD_DATE <= TO_DATE ('" + dateFin + @"', 'yyyymmdd')
                AND
                    SOORDER_DTL.LAST_MOD_DATE>TO_DATE ('01/01/2000', 'dd/mm/yyyy')
                "+ sqlSelected + @"
                GROUP BY 
                    ITEM.ITEM_NO, 
                    SUBSTR(SOORDER_DTL.LAST_MOD_DATE,4,6),
                    SUBSTR(SOORDER_DTL.LAST_MOD_DATE, 8, 2)
                ORDER BY
                    SUBSTR(SOORDER_DTL.LAST_MOD_DATE, 8, 2)
            ";
            
            OracleDataReader dr = execSQL(marequeteSQL);

            int previusDate = 0;
            int indiceAdd = -1;
            while (dr.Read())
            { 
                DateTime datetime = DateTime.ParseExact(dr.GetString(1), "MMM-yy", CultureInfo.CreateSpecificCulture("en-US"));
                int month = datetime.Month;
                int year = datetime.Year;
                decimal value = dr.GetDecimal(2);

                // Console.WriteLine(dr.GetString(1) + " -> "+ "month : " + month + " ; " + "year : " + year + " ; value : " + value);

                if(previusDate != year || previusDate == -1){
                    indiceAdd++;
                    dataGridView1.Rows.Add(13);
                    dataGridView1.Rows[indiceAdd].Cells[0].Value = year;
                    previusDate = year;
                }

                Console.WriteLine("year : " + year + " ; " + "month : " + month + " ; value " + value);
                dataGridView1.Rows[indiceAdd].Cells[month].Value = value;
            }
        }

        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ToCsV(dataGridView1, sfd.FileName); // Here dataGridview1 is your grid view name
            }
        }

        /// <summary>
        /// Récupération des informations sur le produits pour les afficher dans le libellé juste au dessous
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboProduits_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            // Vérification des données
            //
            string productCodeSelected = this.comboProduits.GetItemText(this.comboProduits.SelectedItem);
  
            // Recherche d'informations sur le produit séléctioné
            //
            string marequeteSQL = @"
                SELECT 
                    DESCR
                FROM    
                    SSFRANCE.ITEM_DESC  
                WHERE
                    ITEM_DESC.REF_NO = '"+ productCodeSelected + @"'
                AND
                    ITEM_DESC.LANG_NO = 'F'
            ";

            OracleDataReader dr = execSQL(marequeteSQL);
            dr.Read();

            try
            {
                labelDescProduit.Text = dr.GetString(0);
            } catch(Exception monEx)
            {
                Console.WriteLine(monEx.ToString());
            }
        }

        private void timePickerDepart_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void timePicketFin_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void radioTypeCommandees_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void radioCommandeEtExperdiees_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
