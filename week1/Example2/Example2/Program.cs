using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Person p = new Person();
            p.age = 20;
            p.name = "User1";

            string s = p.ToString();

            Console.Write(s);
            */

            Person2 p2 = new Person2("user", 20);

            Console.Write(p2.ToString());

            Person2 p3 = new Person2();

            Console.ReadKey();
        }
    }
}
