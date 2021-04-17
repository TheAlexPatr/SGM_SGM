using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prilozhua
{
    public partial class Form7 : Form
    {
        private Form9 svyaz = new Form9();
        public Form7()
        {
            InitializeComponent();
            dataGridView1.Rows[0].Cells[0].Value = "Психология людей";
            dataGridView1.Rows[0].Cells[1].Value = "Педагогическая";
            dataGridView1.Rows[0].Cells[2].Value = "1";
            dataGridView1.Rows[0].Cells[3].Value = "11.01.19";
            dataGridView1.Rows[0].Cells[4].Value = "12.01.19";
            dataGridView1.Rows[0].Cells[5].Value = "5";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }
    }
}
