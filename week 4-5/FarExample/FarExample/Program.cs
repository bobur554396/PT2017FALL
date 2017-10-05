using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FarExample
{
    class Program
    {
        static void showInfo(DirectoryInfo dir, int cursor)
        {
            Console.Clear();
            FileSystemInfo[] items = dir.GetFileSystemInfos();

            for(int i = 0; i < items.Length; i++)
            {
                Console.BackgroundColor = (i == cursor) ? ConsoleColor.Blue : ConsoleColor.Black;
                if (items[i].GetType() == typeof(DirectoryInfo))
                    Console.ForegroundColor = ConsoleColor.White;
                if (items[i].GetType() == typeof(FileInfo))
                    Console.ForegroundColor = ConsoleColor.Yellow;
                
                
                Console.WriteLine(items[i].Name);
            }
        }
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int cursor = 0;
            DirectoryInfo dir = new DirectoryInfo(@"C:\\test\");

            ConsoleKeyInfo btn = Console.ReadKey();

            while (btn.Key != ConsoleKey.Q)
            {
                showInfo(dir, cursor);
                btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (cursor > 0)
                            cursor--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (cursor < dir.GetFileSystemInfos().Length)
                            cursor++;
                        break;
                    case ConsoleKey.Enter:
                        FileSystemInfo a = dir.GetFileSystemInfos()[cursor];
                        if(a.GetType() == typeof(DirectoryInfo))
                        {
                            dir = a as DirectoryInfo;
                            cursor = 0;
                        }
                        else if (a.GetType() == typeof(FileInfo))
                        {
                            Process.Start(a.FullName);
                        }
                        break;
                    case ConsoleKey.Escape:
                        dir = dir.Parent;
                        break;
                }
            }

        }
    }
}
