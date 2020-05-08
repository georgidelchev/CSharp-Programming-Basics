using System;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int copyOfTheNum = number;
            int thirdDigit = copyOfTheNum % 10;
            copyOfTheNum /= 10;
            int secondDigit = copyOfTheNum % 10;
            copyOfTheNum /= 10;
            int firstDigit = copyOfTheNum % 10;

            for (int i = 0; i < firstDigit + secondDigit; i++)
            {
                for (int j = 0; j < firstDigit + thirdDigit; j++)
                {
                    if (number % 5 == 0)
                    {
                        number -= firstDigit;
                    }
                    else if (number % 3 == 0)
                    {
                        number -= secondDigit;
                    }
                    else
                    {
                        number += thirdDigit;
                    }
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
        }
    }
}
