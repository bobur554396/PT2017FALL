using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Person2
    {

        // class fields
        private int age;
        private string name;


        // constructor 0
        public Person2() { }

        // constructor 1
        public Person2(string n)
        {
            name = n;
        }

        // constructor 2
        public Person2(string n, int a)
        {
            name = n;
            age = a;
        }

        // setter for field name
        public void setName(string n)
        {
            name = n;
        }

        // getter for name field
        public string getName()
        {
            return name;
        }

        // to string method
        public override string ToString()
        {
            return name + " " + age;
        }

    }
}
