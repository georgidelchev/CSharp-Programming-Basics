using System;

namespace SuitcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());

            int counter = 0;

            string command = Console.ReadLine();
            while (command != "End")
            {
                double caseVolume = double.Parse(command);
                counter++;
                if (counter != 0 && counter % 3 == 0)
                {
                    caseVolume *= 1.1;
                }
                
                if (caseVolume > capacity)
                {
                    counter--;
                    Console.WriteLine($"No more space!");
                    break;
                }
                capacity -= caseVolume;

                command = Console.ReadLine();
            }
            
            if (command == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {counter} suitcases loaded.");

        }
    }
}
