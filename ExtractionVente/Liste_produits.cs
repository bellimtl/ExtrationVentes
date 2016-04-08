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

namespace ExtractionVente
{
    public partial class Liste_produits : Form
    {

        Prevision_des_ventes prev;

        public Liste_produits(Prevision_des_ventes fenetreMere)
        {
            InitializeComponent();
            prev = fenetreMere;
        }

        public void populateTable(OracleConnection conn)
        {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select ITEM_NO, DESCR from SSFRANCE.ITEM, SSFRANCE.ITEM_DESC WHERE SSFRANCE.ITEM.ITEM_NO=SSFRANCE.ITEM_DESC.REF_NO AND LANG_NO='F' ORDER BY ITEM_NO";
            cmd.CommandType = CommandType.Text;

            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataTable dtRecord = new DataTable();
            oda.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;

            dataGridView1.Columns[1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].FillWeight = 100;
        }

        private void boutonSelectProduit_Click(object sender, EventArgs e)
        {
            int indexSelected = dataGridView1.CurrentRow.Index;

            DataGridViewRow ligne = dataGridView1.Rows[indexSelected];
            String valeurCellule = ligne.Cells[0].Value.ToString();
            prev.selectCombo(valeurCellule);

            Form.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
