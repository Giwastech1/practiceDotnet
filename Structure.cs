using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace myFirstProject
{
    internal class Structure
    {
        struct Person
        {
            public string name;
            public int age;
            public int birthMonth;

            public Person(string userName, int userAge,int birthMonth)
            {
                this.name = userName;
                this.age = userAge;
                this.birthMonth = birthMonth;
            }
        }
        public static void Run()
        {
            Person person = ReturnPerson();
            Console.WriteLine($"My name is {person.name} and my age is {person.age}. My birth month {person.birthMonth}");
        }

        static Person ReturnPerson()
        {
            Console.Write("What is you name: ");
            string name = Console.ReadLine();
            Console.Write("What is your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your birth month: ");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            return new Person(name,age,birthMonth);
        }
    }
}