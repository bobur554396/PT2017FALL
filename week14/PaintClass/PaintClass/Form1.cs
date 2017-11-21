using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintClass
{
    public partial class Form1 : Form
    {
        PaintBase paint;
        public Form1()
        {
            InitializeComponent();
            paint = new PaintBase(pictureBox1);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint.prev = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                paint.Draw(e.Location);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint.SaveLast();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            paint.shape = Shape.Rectangle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paint.shape = Shape.Pencil;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            paint.shape = Shape.Circle;
        }
    }
}
