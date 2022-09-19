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
        private string name ;
        private int age;
        public Person()
        {
            name = "0";
            age = 0;
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
    internal class DefineAClassPerson
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
            p1.Age = Convert.ToInt32( Console.ReadLine());
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


        }
    }
}
