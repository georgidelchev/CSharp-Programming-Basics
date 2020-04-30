using System;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneMonetsCount = int.Parse(Console.ReadLine());
            int twoMonetsCount = int.Parse(Console.ReadLine());
            int fiveBucksCount = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= oneMonetsCount; i++)
            {
                for (int j = 0; j <= twoMonetsCount; j++)
                {
                    for (int k = 0; k <= fiveBucksCount; k++)
                    {
                        if (i * 1 + j * 2 + k * 5 == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
