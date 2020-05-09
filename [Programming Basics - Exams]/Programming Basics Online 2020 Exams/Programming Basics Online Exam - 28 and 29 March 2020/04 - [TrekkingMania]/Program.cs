using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsCount = int.Parse(Console.ReadLine());

            double mussalaPeople = 0;
            double montblancPeople = 0;
            double kilimanjaroPeople = 0;
            double k2People = 0;
            double everestPeople = 0;

            double totalPeople = 0;

            for (int i = 0; i < groupsCount; i++)
            {
                int peopleCount = int.Parse(Console.ReadLine());

                if (peopleCount <= 5)
                {
                    mussalaPeople += peopleCount;
                }
                else if (peopleCount >= 6 && peopleCount <= 12)
                {
                    montblancPeople += peopleCount;
                }
                else if (peopleCount >= 13 && peopleCount <= 25)
                {
                    kilimanjaroPeople += peopleCount;
                }
                else if (peopleCount >= 26 && peopleCount <= 40)
                {
                    k2People += peopleCount;
                }
                else if (peopleCount >= 41)
                {
                    everestPeople += peopleCount;
                }
                totalPeople += peopleCount;
            }

            Console.WriteLine($"{(mussalaPeople / totalPeople) * 100:f2}%");
            Console.WriteLine($"{(montblancPeople / totalPeople) * 100:f2}%");
            Console.WriteLine($"{(kilimanjaroPeople / totalPeople) * 100:f2}%");
            Console.WriteLine($"{(k2People / totalPeople) * 100:f2}%");
            Console.WriteLine($"{(everestPeople / totalPeople) * 100:f2}%");

        }
    }
}
