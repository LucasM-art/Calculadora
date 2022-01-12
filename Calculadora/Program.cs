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

            Console.WriteLine("Welcome to the calculator");

            Console.WriteLine("Enter the first number: ");
            userInput1 = Console.ReadLine();
            Console.WriteLine("Enter the second number: ");
            userInput2 = Console.ReadLine();

            num1 = Int32.Parse(userInput1);
            num2 = Int32.Parse(userInput2);

            Calculate(num1, num2);

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
