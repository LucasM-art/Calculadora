using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static int number1;
        static int number2;
        static string sign;

        static string inputOne;
        static string inputTwo;
        static void Main(string[] args)
        {
            bool success;
            bool success2;

            Console.WriteLine("Welcome to the calculator");

            EnterData();

            success = int.TryParse(inputOne, out number1);
            success2 = int.TryParse(inputTwo, out number2);

            if (success && success2)
            {
                Calculate(number1, number2);
            }
            else
            {
                Console.WriteLine("Something went wrong, try again");
                EnterData();
                Calculate(number1, number2);
            }

            Console.Read();
        }

        public static void EnterData()
        {
            Console.WriteLine("Enter the first number: ");
            inputOne = Console.ReadLine();
            Console.WriteLine("Enter the second number: ");
            inputTwo = Console.ReadLine();

            Console.WriteLine("What do you want to do?");
            sign = Console.ReadLine();
        }

        public static void Calculate(int num1, int num2)
        {
            int result;

            if (sign.Equals("+"))
            {
                result = num1 + num2;
                Console.WriteLine("The result is: {0}", result);
            }
            else if (sign.Equals("-"))
            {
                result = num1 - num2;
                Console.WriteLine("The result is: {0}", result);
            }
            else if (sign.Equals("x"))
            {
                result = num1 * num2;
                Console.WriteLine("The result is: {0}", result);
            }
            else if (sign.Equals("/"))
            {
                result = num1 / num2;
                Console.WriteLine("The result is: {0}", result);
            }
        }
    }
}
