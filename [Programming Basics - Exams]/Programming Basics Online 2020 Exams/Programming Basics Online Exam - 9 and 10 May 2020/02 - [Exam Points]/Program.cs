using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int task = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());
            string course = Console.ReadLine();

            double totPoints = 0;
            if (course == "Basics")
            {
                if (task == 1)
                {
                    totPoints = points * 0.08;
                    totPoints -= totPoints * 0.20;
                }
                else if (task == 2)
                {
                    totPoints = points * 0.09;
                }
                else if (task == 3)
                {
                    totPoints = points * 0.09;
                }
                else if (task == 4)
                {
                    totPoints = points * 0.10;
                }
            }
            else if (course == "Fundamentals")
            {
                if (task == 1)
                {
                    totPoints = points * 0.11;
                }
                else if (task == 2)
                {
                    totPoints = points * 0.11;
                }
                else if (task == 3)
                {
                    totPoints = points * 0.12;
                }
                else if (task == 4)
                {
                    totPoints = points * 0.13;
                }
            }
            else if (course == "Advanced")
            {
                if (task == 1)
                {
                    totPoints = points * 0.14;
                }
                else if (task == 2)
                {
                    totPoints = points * 0.14;
                }
                else if (task == 3)
                {
                    totPoints = points * 0.15;
                }
                else if (task == 4)
                {
                    totPoints = points * 0.16;
                }
                totPoints += totPoints * 0.20;
            }
            Console.WriteLine($"Total points: {totPoints:f2}");
        }
    }
}
