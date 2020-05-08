using System;

namespace EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (true)
            {
                Console.Write("Enter even number: ");
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    break;
                }
                Console.WriteLine("The number is not even.");
            }
            Console.WriteLine($"Even number entered: {number}");
        }
    }
}
