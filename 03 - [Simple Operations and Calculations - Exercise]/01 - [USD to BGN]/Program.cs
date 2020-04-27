using System;

namespace UsdToBgn
{
    class Program
    {
        static void Main(string[] args)
        {
            double dollars = double.Parse(Console.ReadLine());
            double convertedToLevs = dollars * 1.79549;
            Console.WriteLine($"{convertedToLevs:f2}");
        }
    }
}
