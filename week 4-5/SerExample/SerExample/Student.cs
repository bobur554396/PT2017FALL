using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerExample
{
    [Serializable]
    public class Student
    {
        public string name;
        public int age;

        public Student() { }

        public Student(string n, int a)
        {
            name = n;
            age = a;
        }

        public override string ToString()
        {
            return name + " " + age;
        }
    }
}
