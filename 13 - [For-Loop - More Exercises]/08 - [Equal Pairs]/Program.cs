using System;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int lastSum = 0;
            int diff = 0;

            for (int i = 0; i < count; i++)
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int sum = first + second;
                if (i > 0)
                {
                    diff = Math.Abs(lastSum - sum);
                }
                lastSum = sum;
            }

            if (diff == 0)
            {
                Console.WriteLine($"Yes, value={lastSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={diff}");
            }
        }
    }
}
