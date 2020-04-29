using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;
            int counter = 0;
            while (counter < number)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers < minNumber)
                {
                    minNumber = numbers;
                }
                counter++;
            }
            Console.WriteLine(minNumber);
        }
    }
}
