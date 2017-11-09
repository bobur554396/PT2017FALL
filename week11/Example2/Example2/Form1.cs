using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example2
{
    public partial class Form1 : Form
    {
        Graphics g;
        int x, y, w, h;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            w = int.Parse(textBox3.Text);
            h = int.Parse(textBox4.Text);
            Pen pen = new Pen(Color.Red, 3);
            Refresh();
            g.DrawRectangle(pen, x, y, w, h);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            w = int.Parse(textBox3.Text);
            h = int.Parse(textBox4.Text);
            Pen pen = new Pen(Color.Red, 3);
            Refresh();
            g.DrawEllipse(pen, x, y, w, h);
        }
    }
}
