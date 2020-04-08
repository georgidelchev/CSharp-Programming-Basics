using System;

namespace Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int heigthWall = int.Parse(Console.ReadLine());
            int widthWall = int.Parse(Console.ReadLine());
            int percentWithNoPaint = int.Parse(Console.ReadLine());

            int total = heigthWall * widthWall * 4;
            double wallsToPaint = Math.Ceiling(total - (total * percentWithNoPaint * 1.00 / 100));

            while (true)
            {
                string liters = Console.ReadLine();
                if (liters == "Tired!")
                {
                    Console.WriteLine($"{wallsToPaint} quadratic m left.");
                    break;
                }
                int paintedLiters = int.Parse(liters);
                wallsToPaint = wallsToPaint - paintedLiters;
                if (wallsToPaint < 0)
                {
                    Console.WriteLine($"All walls are painted and you have {Math.Abs(wallsToPaint)} l paint left!");
                    break;
                }
                else if (wallsToPaint == 0)
                {
                    Console.WriteLine("All walls are painted! Great job, Pesho!");
                    break;
                }
            }
        }
    }
}
