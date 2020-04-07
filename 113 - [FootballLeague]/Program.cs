using System;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int fansCount = int.Parse(Console.ReadLine());

            double sectorA = 0;
            double sectorB = 0;
            double sectorV = 0;
            double sectorG = 0;

            for (int i = 1; i <= fansCount; i++)
            {
                string sector = Console.ReadLine();
                if (sector == "A")
                {
                    sectorA++;
                }
                else if (sector == "B")
                {
                    sectorB++;
                }
                else if (sector == "V")
                {
                    sectorV++;
                }
                else if (sector == "G")
                {
                    sectorG++;
                }
            }
            Console.WriteLine($"{(sectorA / fansCount * 1.00) * 100:f2}%");
            Console.WriteLine($"{(sectorB / fansCount * 1.00) * 100:f2}%");
            Console.WriteLine($"{(sectorV / fansCount * 1.00) * 100:f2}%");
            Console.WriteLine($"{(sectorG / fansCount * 1.00) * 100:f2}%");
            Console.WriteLine($"{(fansCount * 1.00 / stadiumCapacity * 1.00) * 100:f2}%");
        }
    }
}
