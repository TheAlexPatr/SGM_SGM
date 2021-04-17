using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace prilozhua
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "Учебная", "Производственная", "Педагогическая", "Преддипломная" });
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox4.Text = Convert.ToString(e.End);
            textBox4.Text = e.End.ToString("dd/MM/yyyy");
            monthCalendar1.Visible = false;
        }

        public void textBox4_Enter(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        public void textBox5_Enter(object sender, EventArgs e)
        {
            monthCalendar2.Visible = true;
        }

        public void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox5.Text = Convert.ToString(e.End);
            textBox5.Text = e.End.ToString("dd/MM/yyyy");
            monthCalendar2.Visible = false;
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = Convert.ToString(comboBox1.SelectedItem);

        }

        public void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
