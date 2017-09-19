using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        static void f1()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a + b);
        }

        static void f2()
        {
            string s = Console.ReadLine();
            string[] s_arr = s.Split(' ');
            int[] arr = new int[s_arr.Length];
            int sum = 0;
            for(int i = 0; i < s_arr.Length; i++)
            {
                arr[i] = int.Parse(s_arr[i]);
                sum += arr[i];
            }

            foreach(int q in arr)
            {
                Console.Write(q + " ");
            }
            Console.Write('\n');

            Console.WriteLine("Sum = " + sum);

        }
        static void Main(string[] args)
        {
            f2();

            Console.ReadKey();
        }
    }
}
