using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int studsCount = int.Parse(Console.ReadLine());
            int tasksCount = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());

            int totalTasks = 0;
            int totalQuestions = 0;
            while (energy >= 1)
            {
                totalTasks += tasksCount;
                energy += 2 * tasksCount;
                studsCount -= tasksCount;
                energy -= (studsCount * 2) * 3;
                totalQuestions += studsCount * 2;
                if (studsCount < 10)
                {
                    Console.WriteLine("The students are too few!");
                    Console.WriteLine($"Problems solved: {totalTasks}");
                    break;
                }
                studsCount += (studsCount / 10) * 1;
            }
            if (energy <= 0)
            {
                Console.WriteLine("The trainer is too tired!");
                Console.WriteLine($"Questions answered: {totalQuestions}");
            }
        }
    }
}
