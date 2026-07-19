using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace myFirstProject
{
    internal class Function
    {
        public static void Run()
        {
            PrintIntro();
            string name = ReturnName();
            int age = ReturnAge();
            Console.Title = $"{name}-{age}";
            Console.WriteLine($"My name is {name}, I am {age} years old");
            int[] numbers = new int[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ReadnumFromConsole();
            }
            foreach(int number in numbers)
            {
                Console.Write($"{number} ");
            }
        }
        static int ReadnumFromConsole()
        {
            Console.Write("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void PrintIntro()
        {
            Console.WriteLine($"Welcome to my programming session");
        }
        static int ReturnAge()
        {
            return 23;
        }
        static string ReturnName()
        {
            return "Giwa";
        }
    }
}
