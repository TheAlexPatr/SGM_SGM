﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 student = new Form2();
            student.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Form4 rabotodateli = new Form4();
            rabotodateli.ShowDialog();
        }
    }
}