using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();

            int counter = 0;
            double gradesSum = 0;
            while (counter < 12)
            {
                counter++;
                double grades = double.Parse(Console.ReadLine());
                if (grades >= 4.00)
                {
                    gradesSum += grades;
                    
                }
                else if (grades < 4.00)
                {
                    counter--;
                }
            }
            double averageGrade = gradesSum / 12;
            Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
        }
    }
}
