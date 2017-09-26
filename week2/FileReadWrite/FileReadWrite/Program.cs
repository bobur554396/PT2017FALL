using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadWrite
{
    class Program
    {

        static void f1()
        {
            for(int i = 0; i < 5; i++)
            {
                FileInfo file = new FileInfo(@"C:\\test\test_file_"+i+".txt");
                file.Create();
            }
        }

        static void f2(string path, string sum)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(sum);


            sw.Close();
            fs.Close();
        }

        static void f3()
        {
            FileStream fs = new FileStream(@"C:\\test\test_file.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string s = sr.ReadLine();

            string[] s_arr = s.Split(' ');

            int sum = 0;

            foreach(string item in s_arr)
            {
                sum += int.Parse(item);
            }

            f2(@"C:\\test\test_file_0.txt", sum + "");


            sr.Close();
            fs.Close();
        }

        static void f4()
        {
            FileStream fs = new FileStream(@"C:\\test\test_file.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string s = sr.ReadToEnd();

            string[] s_lines = s.Split(new[] { Environment.NewLine }, StringSplitOptions.None);


            string res = "";
            foreach(string item in s_lines)
            {
                string line = "";
                line += item + " = ";
                string[] s_arr = item.Split(' ');
                int sum = 0;

                foreach (string num in s_arr)
                {
                    sum += int.Parse(num);
                }
                line += sum + "\n";

                res += line;
            }

            f2(@"C:\\test\test_file_0.txt", res);
        }


        static void Main(string[] args)
        {
            f4();

            Console.ReadKey();
        }
    }
}
