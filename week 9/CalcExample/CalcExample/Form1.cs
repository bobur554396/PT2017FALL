﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int firstNum = int.Parse(textBox1.Text);
            int secondNum = int.Parse(textBox2.Text);

            int res = firstNum + secondNum;
            textBox3.Text = res + "";
        }
    }
}
