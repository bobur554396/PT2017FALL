using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeExample
{
    class Program
    {

        static void MoveSnake()
        {
            while (!Game.GameOver)
            {
                switch (Game.dir)
                {
                    case 0:
                        Game.snake.Move(1, 0);
                        break;
                    case 1:
                        Game.snake.Move(0, 1);
                        break;
                    case 2:
                        Game.snake.Move(-1, 0);
                        break;
                    case 3:
                        Game.snake.Move(0, -1);
                        break;
                }
                Game.Draw();
                Thread.Sleep(70);
            }
        }

        static void Main(string[] args)
        {
            Game.Init();

            Thread t = new Thread(MoveSnake);
            t.Start();


            while (!Game.GameOver)
            {
                ConsoleKeyInfo btn = Console.ReadKey();

                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        Game.dir = 3;
                        break;
                    case ConsoleKey.DownArrow:
                        Game.dir = 1;
                        break;
                    case ConsoleKey.LeftArrow:
                        Game.dir = 2;
                        break;
                    case ConsoleKey.RightArrow:
                        Game.dir = 0;
                        break;
                }

            }
        }
    }
}
