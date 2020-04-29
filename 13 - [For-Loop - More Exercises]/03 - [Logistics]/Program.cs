using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            double busPercent = 0;
            double truckPercent = 0;
            double trainPercent = 0;
            int totalTons = 0;
            double totalSum = 0;
            
            for (int i = 0; i < count; i++)
            {
                int tons = int.Parse(Console.ReadLine());
                if (tons <= 3)
                {
                    busPercent+=tons;
                    totalSum += 200 * tons;                  
                }
                else if (tons >= 4 && tons <= 11)
                {
                    truckPercent+=tons;
                    totalSum += 175 * tons;
                }
                else if (tons >= 12)
                {
                    trainPercent+=tons;
                    totalSum += 120 * tons;
                }
                totalTons += tons;
            }
            
            Console.WriteLine($"{totalSum / totalTons:f2}");
            Console.WriteLine($"{busPercent/totalTons*100:f2}%");
            Console.WriteLine($"{truckPercent/totalTons*100:f2}%");
            Console.WriteLine($"{trainPercent/totalTons*100:f2}%");
        }
    }
}
