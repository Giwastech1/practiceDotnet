using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstProject
{
    internal class Parameters
    {
        public static void Run()
        {
            string name = ReadString("name");
            int age = ReadInt("age");
            // UserDetail(name, age);
            string userDetails = UserDetail(name, age);
            Console.WriteLine(userDetails);
        }

        static string ReadString(string message)
        {
            Console.Write($"Enter your {message}: ");
            return Console.ReadLine();
        }

        static int ReadInt(string message)
        {
            Console.Write($"Enter your {message}: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static string UserDetail(string name, int age)
        {
            // Console.WriteLine($"My name is {name} and my age is {age}");
            return $"My name is {name} and my age is {age}";
        }
    }
}
