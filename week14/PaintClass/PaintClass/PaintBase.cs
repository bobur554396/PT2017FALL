using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintClass
{
    public enum Shape { Pencil, Rectangle, Circle };

    class PaintBase
    {
        public Graphics g;
        public Bitmap btm;
        public Pen pen;
        public Point prev;
        public GraphicsPath path;
        public PictureBox picture;
        public Shape shape;

        public PaintBase(PictureBox p)
        {
            picture = p;
            btm = new Bitmap(picture.Width, picture.Height);
            picture.Image = btm;
            g = Graphics.FromImage(btm);
            g.Clear(Color.Blue);
            pen = new Pen(Color.Red, 3);
            path = new GraphicsPath();
            shape = Shape.Pencil;

            picture.Paint += Picture_Paint;
        }

        public void Draw(Point cur)
        {
            switch (shape)
            {
                case Shape.Pencil:
                    g.DrawLine(pen, prev, cur);
                    prev = cur;
                    break;
                case Shape.Rectangle:
                    path.Reset();
                    path.AddRectangle(new Rectangle(prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y));
                    break;
                case Shape.Circle:
                    path.Reset();
                    path.AddEllipse(new Rectangle(prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y));
                    break;
            }
            picture.Refresh();            
        }

        private void Picture_Paint(object sender, PaintEventArgs e)
        {
            if (path != null)
                e.Graphics.DrawPath(pen, path);
        }

        public void SaveLast()
        {
            if (path != null)
                g.DrawPath(pen, path);
        }

    }
}
