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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ваш отзыв отправлен!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double otziv = double.Parse(textBox1.Text);
                int b = 11;
                if (b <= otziv)
                {
                    MessageBox.Show("Число не может превышать десять");
                }
            }

            catch (System.FormatException)
            {
                MessageBox.Show("Принимаются только цифровые значения");
            }
                
        }
    }
}
