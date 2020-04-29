using System;

namespace NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    int num = i + j + 1;
                    if (num > number)
                    {
                        num = 2 * number - num;
                    }
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
    }
}
