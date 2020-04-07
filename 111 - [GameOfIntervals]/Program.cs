using System;

namespace GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            double totalPoints = 0;

            double percent0to9 = 0;
            double percent10to19 = 0;
            double percent20to29 = 0;
            double percent30to39 = 0;
            double percent40to50 = 0;

            double invalidNumbersPercent = 0;

            for (int i = 0; i < count; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers >= 0 && numbers <= 50)
                {
                    if (numbers >= 0 && numbers <= 9)
                    {
                        totalPoints += numbers * 0.20;
                        percent0to9++;
                    }
                    else if (numbers >= 10 && numbers <= 19)
                    {
                        totalPoints += numbers * 0.30;
                        percent10to19++;
                    }
                    else if (numbers >= 20 && numbers <= 29)
                    {
                        totalPoints += numbers * 0.40;
                        percent20to29++;
                    }
                    else if (numbers >= 30 && numbers <= 39)
                    {
                        totalPoints += 50;
                        percent30to39++;
                    }
                    else if (numbers >= 40 && numbers <= 50)
                    {
                        totalPoints += 100;
                        percent40to50++;
                    }
                }
                else
                {
                    invalidNumbersPercent++;
                    totalPoints /= 2;
                }
            }
            Console.WriteLine($"{totalPoints:f2}");
            Console.WriteLine($"From 0 to 9: {(percent0to9 / count * 1.00) * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {(percent10to19 / count * 1.00) * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {(percent20to29 / count * 1.00) * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {(percent30to39 / count * 1.00) * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {(percent40to50 / count * 1.00) * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {(invalidNumbersPercent / count * 1.00) * 100:f2}%");
        }
    }
}
