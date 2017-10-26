using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeExample
{
    class Snake
    {
        public List<Point> body;
        public char sign;
        public ConsoleColor color;


        public Snake()
        {
            sign = 'o';
            color = ConsoleColor.Yellow;
            body = new List<Point>();
            body.Add(new Point(12, 10));
            body.Add(new Point(11, 10));
            body.Add(new Point(10, 10));
        }

        public void Move(int x, int y)
        {
            Console.SetCursorPosition(body[body.Count() - 1].x, body[body.Count() - 1].y);
            Console.Write(" ");

            for(int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x += x;
            body[0].y += y;

            if (body[0].x >= 79)
                body[0].x = 0;
            if (body[0].x < 0)
                body[0].x = 80;

            // chack for eat
            // collision with wall
            // collision with border

        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }

    }
}
