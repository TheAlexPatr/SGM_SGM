using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace prilozhua
{
    public partial class Form9 : Form
    {
        int summa = 0;
        string obuchka = "s";
        string obuchenie = "s";
        int cifra = 0;

        public Form9()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cifra = Convert.ToInt32(textBox1.Text);
            }

            catch
            {
                MessageBox.Show("Введите число!");
            }


            if (checkBox1.Checked)
            {
                string m = "Вы очник";
                obuchka = m;
            }

            if (checkBox2.Checked)
            {
                string m = "Вы заочник";
                obuchka = m;

            }

            if (radioButton1.Checked)
            {
                string m = "Вы учитесь в ВУЗе";
                obuchenie = m;
            }

            if (radioButton2.Checked)
            {
                string m = "Вы учитесь в ССУЗе";
                obuchenie = m;
            }

                if (cifra == 5)
                {
                    summa = summa + 5;
                }
            

            string a = @"C:\Users\Alex\Desktop\disane\sertifikat.txt";
            FileStream sa = new FileStream(a, FileMode.OpenOrCreate);
            sa.Close();
           // string b = @"C:\Users\Alex\Desktop\disane\sertifikat.txt";
            // Process.Start(a);
            Thread openFile = new Thread(otkroy);
            openFile.Start();
        }

        public void otkroy()
        {
            string a = @"C:\Users\Alex\Desktop\disane\sertifikat.txt";
            string raikiri = a;
            bool append = true; // задаем перемену, типа истина-ложь
            StreamWriter edo_tensei = new StreamWriter(raikiri, append); // второй аргумент, служит для записи или перезаписи
            edo_tensei.Write("Поздравляем с прохождением!" + "\n" + obuchenie + "\n" + obuchka + "\n" + "Ваш балл:" + summa);
            // edo_tensei.Write("\n",obuchenie + obuchka);
            edo_tensei.Close(); // нужно закрыть поток, иначе не занесет данные
            Process.Start(a);
        }
    }
}
