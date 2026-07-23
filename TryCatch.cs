using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstProject
{
    internal class TryCatch
    {
        public static void Run()
        {
            bool isNotValid = true;
            while (isNotValid)
            {
                try
                {
                    Console.Write("Please, enter a number: ");
                    int inputWord = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"The number you entered is {inputWord}");
                    isNotValid = false;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Error reading input");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Thank you!");
        }
    }
}