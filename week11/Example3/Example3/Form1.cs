using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example3
{
    public partial class Form1 : Form
    {
        Bitmap btm;
        public Form1()
        {
            InitializeComponent();
            btm = new Bitmap(@"image1.png");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(btm, 20, 20);
        }
    }
}
