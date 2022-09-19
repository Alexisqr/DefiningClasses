using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1.DefineAClassPerson
{
    class Person
    {
        private string name;
        private int age;
        public Person()
        {
            name = "No name";
            age = 1;
        }
        public Person(int Age)
        {
            age = Age;
            name = "No name";
            
        }
        public Person(string name,int age)
        {

            Person e3_3 = new Person();
            e3_3.Name = name;
            e3_3.Age = age;
            e3_3.fan();

        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }


        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }


        }

        public void fan()
        {
            Console.WriteLine("Name =" + Name + ", Age = " + Age);
        }


    }
    internal class CreatingConstructors
    {

        static void Main(string[] args)
        {

            Person p1 = new Person();
            Person p2 = new Person();
            Person p3 = new Person();

            Console.Write("Name = ");
            p1.Name = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Age = ");
            p1.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Name = ");
            p2.Name = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Age = ");
            p2.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Name = ");
            p3.Name = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Age = ");
            p3.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            p1.fan();
            p2.fan();
            p3.fan();
            Person e1 = new Person();
            Person e2 = new Person(23);
           
           
            e1.fan();
            e2.fan();
            Person e3 = new Person("Alex", 44);

        }
    }
}
