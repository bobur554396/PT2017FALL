using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirFiles
{
    class Program
    {

        static void f1()
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\test");

            FileInfo[] files = d.GetFiles();

            /*
            for(int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i].Name);
            }
            */

            foreach (FileInfo f in files)
            {
                Console.WriteLine(f.Name);
            }

            DirectoryInfo[] dirs = d.GetDirectories();


            foreach(DirectoryInfo dd in dirs)
            {
                Console.WriteLine(dd.Name);
            }
        }

        static void f2(string path, int depth)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            for (int i = 0; i < depth; i++) Console.Write(" ");
            Console.Write(dir.Name + "\n");
            FileInfo[] files = dir.GetFiles();

            foreach(FileInfo f in files)
            {
                for (int i = 0; i < depth; i++) Console.Write(" ");
                Console.Write(f.Name + "\n");
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            foreach (DirectoryInfo d in dirs)
            {
                f2(d.FullName, depth + 2);
            }


        }

        static void Main(string[] args)
        {
            f2(@"C:\test", 0);

            Console.ReadKey();
        }
    }
}
