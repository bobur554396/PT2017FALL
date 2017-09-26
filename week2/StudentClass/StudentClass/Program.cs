using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "student 1";
            s.Age = 18;

            Student s2 = new Student("student 2", 20, 4);

            Console.Write(s2);

            Console.ReadKey();
        }
    }
}
