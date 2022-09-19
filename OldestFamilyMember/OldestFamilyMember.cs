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
            name = "0";
            age = 0;
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
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
    class Family 
    {
        List<Person> listOfUsers = new List<Person>();
      
        public void AddMember(Person members)
        {
            listOfUsers.Add(members);
        }
        public void Max()
        {
            var sortedList = listOfUsers.OrderByDescending(y => y.Age).FirstOrDefault();
            Console.WriteLine(sortedList.Name +" "+ sortedList.Age);



        }


    }
        internal class DefineAClassPerson
    {

        static void Main(string[] args)
        {
            int N;
            N = Convert.ToInt32(Console.ReadLine());
            var family = new Family();
            for (int i = 0; i < N; i++)
            {
                string nam = Console.ReadLine();
                int ag = Convert.ToInt32(Console.ReadLine());
                var per = new Person(nam, ag);
                family.AddMember(per);
                per.fan();
            }

            family.Max();


        }
    }
}
