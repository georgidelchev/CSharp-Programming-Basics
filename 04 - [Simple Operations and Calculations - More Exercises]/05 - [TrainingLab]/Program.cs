using System;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine())*100;
            double width = double.Parse(Console.ReadLine())*100;

            double corridor = width - 100;
            double desks = Math.Floor(corridor / 70);
            double rows = Math.Floor(length / 120);

            double places = desks * rows - 3;

            Console.WriteLine(places);
        }
    }
}
