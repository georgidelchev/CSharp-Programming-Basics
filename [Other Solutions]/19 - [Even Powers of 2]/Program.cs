using System;

namespace EvenPowersOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int start = 1;
            for (int i = 0; i <= num; i += 2)
            {
                Console.WriteLine(start);
                start = 2 * 2 * start;
            }
        }
    }
}
