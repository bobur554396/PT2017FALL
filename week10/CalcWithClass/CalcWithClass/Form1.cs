using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWithClass
{
    public partial class Form1 : Form
    {
        CalcBase calc = new CalcBase();
        public Form1()
        {
            InitializeComponent();
        }

        private void numbers_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (display.Text == "0")
                display.Text = btn.Text;
            else
                display.Text += btn.Text;
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.firstNumber = float.Parse(display.Text);
            calc.operation = btn.Text;
            display.Text = "";

            //MessageBox.Show(calc.firstNumber + "");
        }

        private void result_click(object sender, EventArgs e)
        {
            calc.secondNumber = float.Parse(display.Text);
            calc.execute();
            display.Text = calc.result + "";
        }


        private void PointClick(object sender, EventArgs e)
        {
            display.Text += ".";
        }

        private void C_click(object sender, EventArgs e)
        {
            calc = new CalcBase();
            display.Text = "0";
        }

        private void PM_click(object sender, EventArgs e)
        {
            calc.tmp = float.Parse(display.Text);
            display.Text = calc.PM().ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int a = int.Parse(display.Text);
            int res = 1;
            for(int i = 1; i <= a; i++)
            {
                res *= i;
            }

            display.Text = res + "";
        }
    }
}
