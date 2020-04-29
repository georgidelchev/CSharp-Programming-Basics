using System;

namespace Number0To100ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] oneToTen = { "zero","one", "two", "three", "four", "five",
                "six", "seven", "eight", "nine", "ten"};
            string[] elevenToTwenty = { "eleven", "twelve", "thirteen", "fourteen", "fifteen",
                "sixteen", "seventeen", "eighteen", "nineteen", "twenty" };
            
                int number = int.Parse(Console.ReadLine());
                if (number >= 0 && number <= 10)
                {
                    Console.WriteLine(oneToTen[number]);
                }
                else if (number >= 11 && number <= 20)
                {
                    Console.WriteLine(elevenToTwenty[number - 11]);
                }
                else if (number >= 21 && number <= 29)
                {
                    int lastDigit = number % 10;
                    Console.Write($"{elevenToTwenty[9]} {oneToTen[lastDigit]}");
                }
                else if (number >= 30 && number <= 39)
                {
                    if (number == 30)
                    {
                        Console.WriteLine("thirty");
                    }
                    else
                    {
                        int lastDigit = number % 10;
                        Console.WriteLine($"thirty {oneToTen[lastDigit]}");
                    }
                }
                else if (number >= 40 && number <= 49)
                {
                    if (number == 40)
                    {
                        Console.WriteLine("forty");
                    }
                    else
                    {
                        int lastDigit = number % 10;
                        Console.WriteLine($"forty {oneToTen[lastDigit]}");
                    }
                }
                else if (number >= 50 && number <= 59)
                {
                    if (number == 50)
                    {
                        Console.WriteLine("fifty");
                    }
                    else
                    {
                        int lastDigit = number % 10;
                        Console.WriteLine($"fifty {oneToTen[lastDigit]}");
                    }
                }
                else if (number >= 60 && number <= 69)
                {
                    if (number == 60)
                    {
                        Console.WriteLine("sixty");
                    }
                    else
                    {
                        int lastDigit = number % 10;
                        Console.WriteLine($"sixty {oneToTen[lastDigit]}");
                    }
                }
                else if (number >= 70 && number <= 79)
                {
                    if (number == 70)
                    {
                        Console.WriteLine("seventy");
                    }
                    else
                    {
                        int lastDigit = number % 10;
                        Console.WriteLine($"seventy {oneToTen[lastDigit]}");
                    }
                }
                else if (number >= 80 && number <= 89)
                {
                    if (number == 80)
                    {
                        Console.WriteLine("eighty");
                    }
                    else
                    {
                        int lastDigit = number % 10;
                        Console.WriteLine($"eighty {oneToTen[lastDigit]}");
                    }
                }
                else if (number >= 90 && number <= 99)
                {
                    if (number == 90)
                    {
                        Console.WriteLine("ninety");
                    }
                    else
                    {
                        int lastDigit = number % 10;
                        Console.WriteLine($"ninety {oneToTen[lastDigit]}");
                    }
                }
                else if (number == 100)
                {
                    Console.WriteLine("one hundred");
                }
            
        }
    }
}
