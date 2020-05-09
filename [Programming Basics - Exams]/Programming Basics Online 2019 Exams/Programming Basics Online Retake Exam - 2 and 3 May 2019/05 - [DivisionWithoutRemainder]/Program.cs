using System;

namespace DivisionWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;


            for (int i = 0; i < counter; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers % 2 == 0)
                {
                    p1++;
                }
                if (numbers % 3 == 0)
                {
                    p2++;
                }
                if (numbers % 4 == 0)
                {
                    p3++;
                }
            }
            Console.WriteLine($"{(p1 / counter * 1.00) * 100:f2}%");
            Console.WriteLine($"{(p2 / counter * 1.00) * 100:f2}%");
            Console.WriteLine($"{(p3 / counter * 1.00) * 100:f2}%");
        }
    }
}