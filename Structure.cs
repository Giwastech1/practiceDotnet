using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstProject
{
    internal class Structure
    {
        struct Person
        {
            public string name;
            public int age;
        }
        public static void Run()
        {
            Person person = new Person();
            person.age = 25;
            Console.WriteLine(person.age);
            person.name = "Giwa";
            Console.WriteLine(person.name);
            Console.WriteLine($"Name: {person.name} - Age: {person.age}");
            Console.WriteLine();
            string name = person.name;
            int age = person.age;
            string returnedString = ReturnPerson(name, age);
            Console.WriteLine(returnedString);
        }

        static string ReturnPerson(string name, int age)
        {
            return $"My name is {name} and my age is {age}";
        }
    }
}