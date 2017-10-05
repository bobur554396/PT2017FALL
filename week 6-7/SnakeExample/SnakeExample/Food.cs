using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeExample
{
    class Food
    {
        public Point location;
        public char sign;
        public ConsoleColor color;

        public Food()
        {
            sign = '$';
            color = ConsoleColor.Green;
            SetRandomPosition();
        }

        public void SetRandomPosition()
        {
            int x = new Random().Next(0, 80);
            int y = new Random().Next(0, 40);
            
            // "x" and "y" on snake or wall? if so, regenerate location.

            location = new Point(x, y);
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(location.x, location.y);
            Console.Write(sign);
        }

    }
}
