using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            bool flag = false;
            int combinationCounter = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    combinationCounter++;
                    if (i + j == magicNumber)
                    {
                        flag = true;
                        Console.WriteLine($"Combination N:{combinationCounter} ({i} + {j} = {magicNumber})");
                        break;
                    }
                }
                if (flag == true)
                {
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
