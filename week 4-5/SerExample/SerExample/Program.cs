using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace SerExample
{
    class Program
    {
        static void f1()
        {
            Student s = new Student("student 1", 18);
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate, FileAccess.Write);


            try
            {
                xs.Serialize(fs, s);
            }
            catch
            {
                Console.WriteLine("error");
            }
            finally
            {
                fs.Close();
            }
        }

        static void f2()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate, FileAccess.Read);
            Student s = new Student();
            try
            {
                s = xs.Deserialize(fs) as Student;
            }
            catch
            {
                Console.Write("error");
            }
            finally
            {
                fs.Close();
            }

            Console.Write(s);
        }

        static void f3()
        {
            Student s = new Student("student 1", 18);
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("data.ser", FileMode.OpenOrCreate, FileAccess.Write);

            try
            {
                bf.Serialize(fs, s);
            }
            catch (SerializationException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        static void f4()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("data.ser", FileMode.OpenOrCreate, FileAccess.Read);
            Student s = new Student();
            try
            {
                s = bf.Deserialize(fs) as Student;
            }
            catch
            {
                Console.Write("error");
            }
            finally
            {
                fs.Close();
            }

            Console.Write(s);
        }


        static void Main(string[] args)
        {
            f4();
            Console.ReadKey();
        }
    }
}
