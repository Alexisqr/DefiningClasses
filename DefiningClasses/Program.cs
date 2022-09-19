using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    namespace Tutlane
    {
        class User
        {
            public string name, location;
            // Default Constructor
            public User()
            {
                name = "Suresh Dasari";
                location = "Hyderabad";
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                // The constructor will be called automatically once the instance of the class created
                User user = new User();
                Console.WriteLine(user.name);
                Console.WriteLine(user.location);
                Console.WriteLine("\nPress Enter Key to Exit..");
                Console.ReadLine();
            }
        }
    }
}
