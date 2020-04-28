using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeOne = int.Parse(Console.ReadLine());
            int timeTwo = int.Parse(Console.ReadLine());
            int timeThree = int.Parse(Console.ReadLine());

            int totalTime = timeOne + timeThree + timeTwo;
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:{seconds:d2}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
