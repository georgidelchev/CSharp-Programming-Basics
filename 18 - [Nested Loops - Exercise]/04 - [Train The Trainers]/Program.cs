using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTheJury = int.Parse(Console.ReadLine());
            double totalGradesSum = 0;
            int presentationsCount = 0;

            string presentationName = Console.ReadLine();
            while (presentationName != "Finish")
            {
                double gradesSum = 0;
                for (int i = 0; i < countOfTheJury; i++)
                {
                    double presentationGrade = double.Parse(Console.ReadLine());
                    gradesSum += presentationGrade;
                    presentationsCount++;
                }
                totalGradesSum += gradesSum;
                double averageGrade = gradesSum / countOfTheJury;
                Console.WriteLine($"{presentationName} - {averageGrade:f2}.");

                presentationName = Console.ReadLine();
            }
            double finalGrade = totalGradesSum / presentationsCount;
            Console.WriteLine($"Student's final assessment is {finalGrade:f2}.");
        }
    }
}
