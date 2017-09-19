using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKeyButtons
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo btn = Console.ReadKey();

            while (btn.Key != ConsoleKey.Q)
            {
                if(btn.Key == ConsoleKey.UpArrow)
                {
                    Console.WriteLine("Up arrow clicked");
                }
                if(btn.Key == ConsoleKey.LeftArrow)
                {
                    Console.WriteLine("Left arrow clicked");
                }
                btn = Console.ReadKey();
            }

        }
    }
}
