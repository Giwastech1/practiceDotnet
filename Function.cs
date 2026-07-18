using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstProject
{
    internal class Function
    {
        static string myName = "Giwa Toheeb";
        public static void Run()
        {
            Console.WriteLine("Hello function method\nWelcome to my program.");
            PrintArray();
            Console.Title = myName;
        }
          static void PrintArray()
        {
            int[] myArray = new int[] { 0, 1, 2 };
            foreach (int num in myArray)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            Console.WriteLine(myName+);
        }
    }
}
