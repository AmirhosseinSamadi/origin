using System;

namespace ConsoleApp2
{
    public class Program
    {
        static int Fibonachi(int n)
        {
            if (n == 1)
                return 1;
            else if (n == 2)
                return 1;
            else
                return (Fibonachi(n - 1) + Fibonachi(n - 2));
        }

        public static void Main(string[] args)
        {
            int Fib = Fibonachi(5);
            Console.WriteLine(Fib);
        }
    }
}