using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double sum = 0;
            for (int i = 0; i < number; i++)
            {
                double numbers = double.Parse(Console.ReadLine());
                sum += numbers;
            }
            Console.WriteLine($"{sum/number:f2}");
        }
    }
}
