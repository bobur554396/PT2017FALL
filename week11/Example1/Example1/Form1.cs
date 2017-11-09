using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1
{
    public partial class Form1 : Form
    {
        //Graphics g;

        public Form1()
        {
            InitializeComponent();
            //g = this.CreateGraphics();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 3);

            Point p1 = new Point(10, 200);
            Point p2 = new Point(200, 200);

            e.Graphics.DrawLine(pen, p1, p2);


            Pen pen2 = new Pen(Color.Green, 5);

            //e.Graphics.DrawRectangle(pen2, 20, 20, 100, 200);

            Rectangle r = new Rectangle(20, 20, 200, 200);

            //e.Graphics.DrawRectangle(pen2, r);

            e.Graphics.DrawEllipse(pen2, r);
        }

    }
}
