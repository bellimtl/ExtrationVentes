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
    public partial class Form1 : Form
    {
        string oradb;
        OracleConnection conn;

        public Form1()
        {
            InitializeComponent();

            oradb = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=SYNERGYSRV2)(PORT=1521))(CONNECT_DATA=(SERVER = DEDICATED)(SERVICE_NAME=ORA11G))); User Id = READ_ONLY_USER; Password = ROUSER;";
            conn  = new OracleConnection(oradb);
            conn.Open();

            // Initialisation de la combo
            //
            init_combo();
        }

        private void onclickevent(object sender, EventArgs e)
        {
            
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select ITEM_NO from SSFRANCE.ITEM";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            int i = 0;
            while (dr.Read())
            {
                i++;

                string myItem = dr.GetString(0);
                label1.Text += myItem;
                listBox1.Items.Add(myItem);
                tableLayoutPanel1.Controls.Add(new Label() { Text = myItem, Anchor = AnchorStyles.Left, AutoSize = true }, 0, 0);
                ComboProducts.Items.Add(myItem);

                this.ProgressBar.Increment(1);

                if (i > 10)
                    break;
            }

            conn.Dispose();

            // listBox1.Items.Add(((TextBox)sender).Text);
        }

        /// <summary>
        /// Initializing combo box
        /// </summary>
        private void init_combo()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select ITEM_NO from SSFRANCE.ITEM";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            // Limit the number of product to 10
            int i = 0;
            while (dr.Read() && i<10)
            {
                i++;

                string myItem = dr.GetString(0);
                ComboProducts.Items.Add(myItem);
            }
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

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void t(object sender, DragEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            init_combo();
        }
    }
}
