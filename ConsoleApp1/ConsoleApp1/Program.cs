using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long number1;
            long number2;
            Console.WriteLine("Enter the operator :");
            string op = Console.ReadLine();
            Console.WriteLine("Enter the first number :");
            number1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the second number :");
            number2 = Convert.ToInt64(Console.ReadLine());
            if (op == "+")
            {
                long result = number1 + number2;
                Console.WriteLine("result of {0} + {1} is {2}", number1, number2, result);
            }
            else if (op == "-")
            {
                long result = number2 - number1;
                Console.WriteLine("result of {0} - {1} is {2}", number1, number2, result);
            }
            else if (op == "*")
            {
                long result = number1 * number2;
                Console.WriteLine("result of {0} * {1} is {2}", number1, number2, result);
            }
            else if (op == "/")
            {
                double result = number1 / number2;
                Console.WriteLine("result of {0} / {1} is {2}", number1, number2, result);
                Console.ReadKey();
            }
        }
    }
}
