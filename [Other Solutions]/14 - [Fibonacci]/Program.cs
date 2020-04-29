using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int f0 = 1;
            int f1 = 1;
            for (int i = 0; i < number - 1; i++)
            {
                int fibonacciNumber = f0 + f1;
                f0 = f1;
                f1 = fibonacciNumber;
            }
            Console.WriteLine(f1);
        }
    }
}
