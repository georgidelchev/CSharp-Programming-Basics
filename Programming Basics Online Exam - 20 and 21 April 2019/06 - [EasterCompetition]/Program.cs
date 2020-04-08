using System;

namespace EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBreadsCount = int.Parse(Console.ReadLine());

            string nameCooker = "";
            int maxPoints = 0;


            for (int i = 1; i <= easterBreadsCount; i++)
            {
                int points = 0;

                string name = Console.ReadLine();
                string grade = Console.ReadLine();
                while (grade != "Stop")
                {
                    int grades = int.Parse(grade);
                    points += grades;
                    grade = Console.ReadLine();
                }
                Console.WriteLine($"{name} has {points} points.");

                if (points > maxPoints)
                {
                    maxPoints = points;
                    nameCooker = name;
                    Console.WriteLine($"{nameCooker} is the new number 1!");
                }

            }

            Console.WriteLine($"{nameCooker} won competition with {maxPoints} points!");
        }
    }
}
