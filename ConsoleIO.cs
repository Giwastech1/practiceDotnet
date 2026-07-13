using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace myFirstProject
{
    internal class ConsoleIO
    {
        public static void Run()
        {
            /* Console.Write("What is your name: ");
             string name = Console.ReadLine();
             Console.Write("What is your age: ");
             string age = Console.ReadLine();
             Console.WriteLine();
             Console.Write("Your name is ");
             Console.WriteLine(name);
             Console.Write("Your age is ");
             Console.WriteLine(age);
             Console.WriteLine();
            */
            //Contantenation
            /*
            Console.Write("What is your name: ");
            string myName = Console.ReadLine();
            Console.Write("What is your age: ");
            string myAge = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your name is "+myName+" while your age is "+myAge);
            Console.WriteLine();

            //Convert age string to an integer
            int convertAge = Convert.ToInt32(myAge);

            //If statement
            if (convertAge >= 35)
            {
                Console.WriteLine("You are 30 years old or older");
            }
            else if (convertAge >= 18)
            {
                Console.WriteLine("You are 18 years old or older");
            }
            */
            Console.WriteLine();
            /*
            Console.Write("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int actualAnswer = firstNumber * secondNumber;
            Console.Write("The result of "+firstNumber + " x "+secondNumber + " is : ");
            int result = Convert.ToInt32(Console.ReadLine());
            if (result == actualAnswer)
            {
                Console.WriteLine("Welldone!");
            }
            else
            {
                Console.WriteLine("Close but wrong");
            }
            */

            //Switch statement
            /*
             Console.Write("Enter a day of the week: ");
             int day = Convert.ToInt32(Console.ReadLine());
             switch(day)
             {
                 case 1: Console.WriteLine("Monday");
                     break;
                 case 2: Console.WriteLine("Tuesday");
                     break;
                 case 3: Console.WriteLine("Wednesday");
                     break;
                 case 4: Console.WriteLine("Thursday");
                     break;
                 case 5: Console.WriteLine("Friday");
                     break;
                 case 6: Console.WriteLine("Saturday");
                     break;
                 case 7: Console.WriteLine("Sunday");
                     break;
                 default: Console.WriteLine("Wrong input");
                     break;
             }
            */
            //Loop 
            /*
            Console.Write("How many times do you wish to iterate? : ");
            int iteration =  Convert.ToInt32(Console.ReadLine());
            Console.Write("What message do you want to print? : ");
            string message = Console.ReadLine();
            Console.WriteLine();
            for (int i = 1; i <= iteration; i++)
            {
                Console.WriteLine(i+" "+message);
            }
            */
            /*
            Console.Write("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int actualAnswer = firstNumber * secondNumber;
            Console.WriteLine();
            int answer = 0;
            while (answer != actualAnswer)
            {
                Console.Write("The value of " + firstNumber + " x " + secondNumber + " is: ");
                answer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (answer != actualAnswer) {
                    Console.WriteLine("So close but that is wrong");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Well-done!");
            */

            //Conditional operator/ ternary operator
            int age = -10;
            string result = age < 0 ? "Invalid" : "Valid";
            Console.WriteLine(result);
            Console.WriteLine();
            //Numeric formatting
            /*
            double value = 100D /7D;
            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0:0.00},{1} {2}",value,"second","third"));
            */

            /*
            double money = -10D / 3D;
            Console.WriteLine(string.Format("The result of -£10/£3 is £{0:0.0}",money));
            Console.WriteLine(money);
            Console.WriteLine(money.ToString());
            Console.WriteLine(money.ToString("C"));
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));
            */

            //Tryparse
            /*
            bool success = false;
            while (!success)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                int number = 0;
                if (int.TryParse(input, out number))
                {
                    Console.WriteLine(number);
                    success = true;
                }
                else
                {
                    Console.WriteLine("Error during conversion");
                }
            }
            */
            //Exercise
            /*
            Console.Write("Enter the number of table: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                //Console.WriteLine(i+" x "+num+" = "+i*num);
                Console.WriteLine("{0} x {1} = {2}", i, num, i * num);
            }
            */
            /*
            string path = "\\user\\desktop\\tutorial\nhi";
            string myString = "He said 'I am coming.'";
            string myString2 = @"He said ""I am coming.""";
            Console.WriteLine(path);
            Console.WriteLine(myString);
            Console.WriteLine(myString2);
            */
            /*
            string message = "C# is awsome";
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(80);
            }
            if (message.Equals(""))
            {
                Console.WriteLine("0");
            }
            Console.WriteLine();
            Console.WriteLine("1");
            */

            /*
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Your name is {name}");
            if (!string.IsNullOrEmpty(name))
            {
                Console.WriteLine("0");
            }
            if (!name.Equals(""))
            {
                Console.WriteLine("0");
            }
            
            if (!name.Equals(null))
            {
                Console.WriteLine("0");
            } 
            */

            /*
            Console.Write("Enter a message: ");
            string input = Console.ReadLine();
            //loop and print in order
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
            //loop and print in reverse
            for (int i = input.Length-1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            */

            //Password checker exercise
            /*
            Console.WriteLine("Enter a password: ");
            string password = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(password))
            {
                Console.Write("Re enter your password: ");
                string confrimed = Console.ReadLine();
                if (password == confrimed)
                {
                    Console.WriteLine("Passwords matched");
                }
                else
                {
                    Console.WriteLine("Passwords do not matched");
                }
            } else
            {
                Console.WriteLine("Please, enter a password.");
            }
            */
            /*
            int[] numbers = new int[3];
            Console.Write("Enter the first number:");
            numbers[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            numbers[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{numbers[0]} {numbers[1]} {numbers[2]}");
            */

            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}