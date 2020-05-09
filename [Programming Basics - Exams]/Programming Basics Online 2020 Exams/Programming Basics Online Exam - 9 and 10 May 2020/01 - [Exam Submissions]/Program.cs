using System;

namespace ExamSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStudents = int.Parse(Console.ReadLine());
            int numTasks = int.Parse(Console.ReadLine());

            double tasks = Math.Ceiling(numTasks * 2.8) * numStudents;

            int addSolutions = numTasks / 3 * numStudents;

            double totalSolutions = tasks + addSolutions;

            double memory = Math.Ceiling(totalSolutions / 10) * 5;

            Console.WriteLine($"{memory} KB needed");
            Console.WriteLine($"{totalSolutions} submissions");
        }
    }
}