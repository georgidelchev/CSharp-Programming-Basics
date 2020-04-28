using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            double scholarship = 0;
            double scolarshipExcellent = 0;

            if (income <= minimalSalary && averageSuccess > 4.50 && averageSuccess < 5.50)
            {
                scholarship = Math.Floor(minimalSalary * 0.35);
                Console.WriteLine($"You get a Social scholarship {scholarship} BGN");
            }
            else if (averageSuccess >= 5.50)
            {
                scolarshipExcellent = Math.Floor(averageSuccess * 25);
                Console.WriteLine($"You get a scholarship for excellent results {scolarshipExcellent} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
