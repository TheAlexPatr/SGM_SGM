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
    public partial class Form6 : Form
    {
        private Form9 svyaz = new Form9();
        public Form6()
        {
            InitializeComponent();
            dataGridView1.Rows[0].Cells[0].Value = "Работа в C#";
            dataGridView1.Rows[0].Cells[1].Value = "Учебная";
            dataGridView1.Rows[0].Cells[2].Value = "3";
            dataGridView1.Rows[0].Cells[3].Value = "15.02.20";
            dataGridView1.Rows[0].Cells[4].Value = "18.02.20";
            dataGridView1.Rows[0].Cells[5].Value = "1";
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
