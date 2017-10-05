using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeExample
{
    class Wall
    {
        public List<Point> body;
        public ConsoleColor color;
        public char sign;
        public int level;

        public Wall()
        {
            color = ConsoleColor.Red;
            sign = '#';
            body = new List<Point>();
            level = 1;
            LoadLevel(level);
        }

        public void LoadLevel(int l)
        {
            string filename = string.Format(@"Levels\level{0}.txt", l);

            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string line = "";
            int row = -1;

            while((line = sr.ReadLine()) != null)
            {
                row++;
                for (int col = 0; col < line.Length; col++)
                {
                    if (line[col] == '#')
                        body.Add(new Point(col, row));
                }
            }
        }
        

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
    }
}
