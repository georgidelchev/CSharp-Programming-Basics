using System;

namespace UniquePins
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumberUpperBorder = int.Parse(Console.ReadLine());
            int secondNumberUpperBorder = int.Parse(Console.ReadLine());
            int thirdNumberUpperBorder = int.Parse(Console.ReadLine());

            for (int i = 1; i <= firstNumberUpperBorder; i++)
            {
                for (int j = 1; j <= secondNumberUpperBorder; j++)
                {
                    for (int k = 1; k <= thirdNumberUpperBorder; k++)
                    {
                        if ((i % 2 == 0 && k % 2 == 0) &&
                        ((j == 2 || j == 3 || j == 5 || j == 7)))
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}
