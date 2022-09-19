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
            Console.WriteLine(sortedList.Name + " " + sortedList.Age);



        }
        public void Bil(int N)
        {
            int r;
            r = 0;
            listOfUsers.Sort((x, y) => x.Name.CompareTo(y.Name));
            
            for (int i = 0; i < N; i++)
            {
                var sortedList = listOfUsers[i];
                if (sortedList.Age >= 30)
                {
                    Console.WriteLine(sortedList.Name + " " + sortedList.Age);
                   
                    r++;
                }
            }

           

        }
        internal class DefineAClassPerson
        {

            static void Main(string[] args)
            {
                string R1;
                int N;
                N = Convert.ToInt32(Console.ReadLine());
                var family = new Family();
                for (int i = 0; i < N; i++)
                {
                    R1 = Console.ReadLine();
                    string[] nom = R1.Split(' ');
                    string nam = nom[0];
                    int ag = Convert.ToInt32(nom[1]);
                    var per = new Person(nam, ag);
                    family.AddMember(per);
                    
                }

               

                family.Bil(N);

            }
        }
    }

}