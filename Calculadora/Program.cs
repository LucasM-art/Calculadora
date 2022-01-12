using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput1;
            string userInput2;

            int num1;
            int num2;

            bool success;
            bool success2;

            Console.WriteLine("Welcome to the calculator");

            Console.WriteLine("Enter the first number: ");
            userInput1 = Console.ReadLine();
            Console.WriteLine("Enter the second number: ");
            userInput2 = Console.ReadLine();

            success = int.TryParse(userInput1, out num1);
            success2 = int.TryParse(userInput2, out num2);

            if (success && success2)
            {
                Calculate(num1, num2);
            }
            else
            {
                Console.WriteLine("Something went wrong, try again");
            }

            Console.Read();
        }

        public static void Calculate(int num1, int num2)
        {
            string sign;
            int result;

            Console.WriteLine("What do you want to do?");
            sign = Console.ReadLine();

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
