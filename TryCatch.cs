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
            Console.Write("Enter a number: ");
            try
            {
                int inputWord = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"The number you enter is {inputWord}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a correct number format");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Plese enter a number between 0 and 2billion");
            }
            Console.WriteLine();
            Console.WriteLine("Thank you");
        }
    }
}