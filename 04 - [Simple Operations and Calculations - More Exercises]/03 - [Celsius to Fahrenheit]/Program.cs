using System;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double deg = double.Parse(Console.ReadLine());
            double far = (deg * 1.80) + 32;
            Console.WriteLine($"{far:f2}");
        }
    }
}
