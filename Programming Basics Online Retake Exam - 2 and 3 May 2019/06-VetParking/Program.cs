using System;

namespace VetParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double tax = 0;
            double totalSum = 0;
            for (int i = 1; i <= days; i++)
            {
                double sum = 0;
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        tax = 2.50;
                        sum += tax;
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        tax = 1.25;
                        sum += tax;
                    }
                    else
                    {
                        tax = 1.00;
                        sum += tax;
                    }
                }
                totalSum += sum;
                Console.WriteLine($"Day: {i} - {sum:f2} leva");
            }
            Console.WriteLine($"Total: {totalSum:f2} leva");
        }
    }
}