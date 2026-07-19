using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstProject
{
    internal class Function
    {
        public static void Run()
        {
            string name = PrintIntro();
            int age = MyAge();
            Console.WriteLine($"My name is {name}, I am {age} years of age");
        }
        static string PrintIntro()
        {
            return "Giwa!";
        }
        static int MyAge()
        {
            return 23;
        }
    }
}
