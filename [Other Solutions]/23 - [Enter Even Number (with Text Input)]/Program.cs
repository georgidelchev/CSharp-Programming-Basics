using System;

namespace EnterEvenNumber_with_Text_Input_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter even number: ");
                    int number = int.Parse(Console.ReadLine());
                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"Even number entered: {number}");
                        break;
                    }
                    Console.WriteLine("The number is not even.");

                }
                catch
                {
                    Console.WriteLine("Invalid number.");
                }

            }
        }
    }
}
