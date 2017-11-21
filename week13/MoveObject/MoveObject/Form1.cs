using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveObject
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p;
        int x = 10, dx = 10;
        int y = 100, dy = 10;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            p = new Pen(Color.Red, 3);
            timer1.Interval = 100;
            timer1.Enabled = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush b = new SolidBrush(Color.Red);
            g.FillEllipse(b, x, y, 50, 50);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x + 70 > Width)
                dx *= -1;
            if (x < 0)
                dx *= -1;

            if (y + 90 > Height)
                dy *= -1;
            if (y < 0)
                dy *= -1;

            x += dx;
            y += dy;

            Refresh();
        }
    }
}
