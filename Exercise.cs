using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstProject
{
    internal class Exercise
    {
        public static void Run()
        {
            int[] number = new int[5];

            int totalOfAll = SumOfNumbers(number);

            if (totalOfAll > -1) {
                Console.WriteLine($"The total is {totalOfAll}");
            }
            else
            {
                Console.WriteLine("Cannot add an empty array");
            }
        }
        static int SumOfNumbers(int[] arrays)
        {
            if (arrays.Length == 0)
            {
                return -1;
            }
            int total = 0;
            for (int i = 0; i < arrays.Length; i++)
            {
                total += arrays[i];
            }
            return total;
        }
    }
}