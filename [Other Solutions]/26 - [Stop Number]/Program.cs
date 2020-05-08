using System;

namespace StopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int stoppingNumber = int.Parse(Console.ReadLine());

            for (int i = M; i >= N; i--)
            {
                if ((i % 2 == 0) && (i % 3 == 0))
                {
                    if (i == stoppingNumber)
                    {
                        break;
                    }
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
