using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int counter = 1;
            while (counter <= number)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers > maxNumber)
                {
                    maxNumber = numbers;
                }
                counter++;
            }
            Console.WriteLine(maxNumber);
        }
    }
}
