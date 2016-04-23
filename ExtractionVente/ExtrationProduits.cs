using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtractionVente
{
    public partial class ExtrationProduits : Form
    {
        // OracleConnection conn;

        public ExtrationProduits()
        {
            InitializeComponent();
        }

        private void initTable ()
        {
            OracleCommand cmd = new OracleCommand();
           //  cmd.Connection = conn;
            cmd.CommandText = "select ITEM_NO, DESCR from SSFRANCE.ITEM, SSFRANCE.ITEM_DESC WHERE SSFRANCE.ITEM.ITEM_NO=SSFRANCE.ITEM_DESC.REF_NO AND LANG_NO='F' ORDER BY ITEM_NO";
            cmd.CommandType = CommandType.Text;

            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataTable dtRecord = new DataTable();
            oda.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;

            dataGridView1.Columns[1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].FillWeight = 100;
        }

        private void calculMoyenne(string codeProduit)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            var points = new List<PointD>()
            {
                new PointD{X=2012,Y=407},
                new PointD{X=2013,Y=540},
                new PointD{X=2014,Y=422}
            };

            var a = RegressionLineaire.Variance(points, p => p.X, p => p.Y) / RegressionLineaire.Variance(points, p => p.X, p => p.X);
            var b = points.Average(p => p.Y) - a * points.Average(p => p.X);

            Console.WriteLine(a);
            Console.WriteLine(b);

            int x = 2015;

            double y = a * x + b;

            Console.WriteLine("y = " + y);
            */
        }
    }
}
