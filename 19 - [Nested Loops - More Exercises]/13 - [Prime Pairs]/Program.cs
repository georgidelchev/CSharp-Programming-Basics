using System;

namespace PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingValueOfFirstTwo = int.Parse(Console.ReadLine());
            int startingValueOfSecondTwo = int.Parse(Console.ReadLine());
            int differenceBetweenStartAndEndFirst = int.Parse(Console.ReadLine());
            int differenceBetweenStartAndEndSecond = int.Parse(Console.ReadLine());

            for (int i = startingValueOfFirstTwo; i <= startingValueOfFirstTwo + differenceBetweenStartAndEndFirst; i++)
            {
                for (int j = startingValueOfSecondTwo; j <= startingValueOfSecondTwo + differenceBetweenStartAndEndSecond; j++)
                {
                    bool isIPrime = true;
                    bool isJPrime = true;

                    for (int k = 2; k <= Math.Sqrt(i); k++)
                    {
                        if (i % k == 0)
                        {
                            isIPrime = false;
                            break;
                        }
                    }
                    for (int k = 2; k <= Math.Sqrt(j); k++)
                    {
                        if (j % k == 0)
                        {
                            isJPrime = false;
                            break;
                        }
                    }
                    if (isIPrime && isJPrime)
                    {
                        Console.WriteLine($"{i}{j}");
                    }
                }
            }
        }
    }
}
