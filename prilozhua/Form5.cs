using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prilozhua
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;
            k++;
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Excel (*.XLS)|*.XLS"; // фильры а чё
            opf.ShowDialog();
            DataTable tb = new DataTable();
            string filename = opf.FileName;
            if (filename == "")
            {
                MessageBox.Show("s");
            }
            string ConStr = String.Format("Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0}; Extended Properties=Excel 8.0;", filename);
            System.Data.DataSet ds = new System.Data.DataSet("EXCEL");
            OleDbConnection cn = new OleDbConnection(ConStr);
            cn.Open();
            DataTable schemaTable = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            string sheet1 = (string)schemaTable.Rows[0].ItemArray[2];
            string select = String.Format("SELECT * FROM [{0}]", sheet1);
            OleDbDataAdapter ad = new OleDbDataAdapter(select, cn);
            ad.Fill(ds);
            DataTable tb1 = ds.Tables[0];
            cn.Close();
            dataGridView1.DataSource = tb1;
            if (k > 1)
            {
                string ConStr1 = String.Format("Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0}; Extended Properties=Excel 8.0;", filename);
                System.Data.DataSet ds1 = new System.Data.DataSet("EXCEL");
                OleDbConnection cn1 = new OleDbConnection(ConStr);
                cn.Open();
                DataTable schemaTable1 = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                string sheet11 = (string)schemaTable.Rows[0].ItemArray[2];
                string select1 = String.Format("SELECT * FROM [{0}]", sheet1);
                OleDbDataAdapter ad1 = new OleDbDataAdapter(select, cn);
                ad.Fill(ds);
                DataTable tb11 = ds.Tables[0];
                cn.Close();
                dataGridView1.DataSource = tb1;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
