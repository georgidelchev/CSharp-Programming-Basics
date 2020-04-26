using System;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double squareArea = number * number;
            Console.WriteLine(squareArea);
        }
    }
}
