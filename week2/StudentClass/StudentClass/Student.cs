using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Student
    {
        string name;
        int age;
        float gpa;

        public Student() { }

        public Student(string name, int age, float gpa)
        {
            this.name = name;
            this.age = age;
            this.gpa = gpa;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return name + "\n" + age + "\n" + gpa;
        }

    }

}
