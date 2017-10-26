using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeExample
{
    class Game
    {
        public static Food food;
        public static Snake snake;
        public static Wall wall;
        public static bool GameOver;
        public static int dir = 0;

        public static void Init()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 40);

            food = new Food();
            snake = new Snake();
            wall = new Wall();
            GameOver = false;
        }

        public static void Draw()
        {
            //Console.Clear();
            food.Draw();
            snake.Draw();
            wall.Draw();
        }
    }
}
