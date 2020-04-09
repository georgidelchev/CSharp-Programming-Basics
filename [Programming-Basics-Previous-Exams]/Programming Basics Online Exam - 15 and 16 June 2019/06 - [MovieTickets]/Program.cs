using System;

namespace MovieTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (char i = (char)a1; i <= a2 - 1; i++)
            {
                for (int i2 = 1; i2 <= n - 1; i2++)
                {
                    for (int i3 = 1; i3 <= n / 2 - 1; i3++)
                    {
                        if (i % 2 == 1 && (i2 + i3 + i) % 2 == 1)
                        {
                            Console.WriteLine($"{i}-{i2}{i3}{(int)i}");
                        }
                    }
                }
            }
        }
    }
}
