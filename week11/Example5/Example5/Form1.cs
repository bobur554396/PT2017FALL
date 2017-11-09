using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example5
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;
        int w = 20, h = 20;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            pen = new Pen(Color.Red, 2);
            timer1.Interval = 100;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //g.DrawEllipse(pen, 300, 200, w, h);
            g.DrawRectangle(pen, 300, 200, w, h);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            w += 10;
            h += 10;
            Refresh();
        }
    }
}
