using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());

            double lowPercent = 0;
            double averagePercent = 0;
            double goodPercent = 0;
            double excellentPercent = 0;

            double gradesSum = 0;
            double averageSuccess = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 2.00 && grade <= 2.99)
                {
                    lowPercent++;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    averagePercent++;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    goodPercent++;
                }
                else if (grade >= 5.00)
                {
                    excellentPercent++;
                }
                gradesSum += grade;
            }
            Console.WriteLine($"Top students: {(excellentPercent / studentsCount * 1.00) * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(goodPercent / studentsCount * 1.00) * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(averagePercent / studentsCount * 1.00) * 100:f2}%");
            Console.WriteLine($"Fail: {(lowPercent / studentsCount * 1.00) * 100:f2}%");
            Console.WriteLine($"Average: {(gradesSum / studentsCount * 1.00):f2}");
        }
    }
}
