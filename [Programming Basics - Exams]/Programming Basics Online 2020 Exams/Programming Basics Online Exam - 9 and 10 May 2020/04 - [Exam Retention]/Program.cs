using System;

namespace ConsoleApp3
{
    class Program
    {

        static void Main(string[] args)
        {
            int studsCount = int.Parse(Console.ReadLine());
            int seasonsCount = int.Parse(Console.ReadLine());
            double newStuds = 0;
            double continues = 0;

            double examForSecondCourse = 0;
            for (int i = 1; i <= seasonsCount; i++)
            {
                double examForFirstCourse = Math.Ceiling(studsCount * 0.9);
                examForSecondCourse = Math.Ceiling(examForFirstCourse * 0.9);
                continues = Math.Ceiling(examForSecondCourse * 0.8);

                if (i % 3 == 0)
                {
                    newStuds = Math.Ceiling(continues * 0.15);
                }
                else
                {
                    newStuds = Math.Ceiling(continues * 0.05);
                }
                studsCount = (int)newStuds + (int)continues;
            }

            Console.WriteLine($"Students: {continues + newStuds}");
        }
    }
}
