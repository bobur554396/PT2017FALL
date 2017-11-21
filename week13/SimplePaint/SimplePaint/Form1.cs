using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap btm;
        Pen pen;
        Point prev;
        GraphicsPath path;
        public Form1()
        {
            InitializeComponent();
            btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = btm;
            g = Graphics.FromImage(btm);
            pen = new Pen(Color.Red, 1);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prev = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Point cur = e.Location;
            if (e.Button == MouseButtons.Left)
            {
                g.DrawLine(pen, prev, cur);
                prev = cur;
            } 

            pictureBox1.Refresh();
        }
    }
}
