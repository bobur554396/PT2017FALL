using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcDemo
{
    public partial class Form1 : Form
    {
        int firstNumber, secondNumber, result;
        string operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void numbers_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            display.Text += btn.Text;
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            firstNumber = int.Parse(display.Text);
            operation = btn.Text;
            display.Text = "";
        }

        private void result_click(object sender, EventArgs e)
        {
            secondNumber = int.Parse(display.Text);


            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
            }

            display.Text = result + "";
        }



    }
}
