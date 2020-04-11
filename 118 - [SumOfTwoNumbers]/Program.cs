using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            bool isMagicNumberFound = false;
            int magicNumber = int.Parse(Console.ReadLine());
            int comb = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    comb++;
                    if (i + j == magicNumber)
                    {
                        isMagicNumberFound = true;
                        Console.WriteLine($"Combination N:{comb} ({i} + {j} = {magicNumber})");
                        return;
                    }
                }
            }
            if (!isMagicNumberFound)
            {
                Console.WriteLine($"{comb} combinations - neither equals {magicNumber}");
            }
        }
    }
}
