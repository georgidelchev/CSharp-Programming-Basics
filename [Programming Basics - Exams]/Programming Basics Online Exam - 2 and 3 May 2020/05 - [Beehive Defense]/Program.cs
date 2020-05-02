using System;

namespace BeehiveDefense
{
    class Program
    {
        static void Main(string[] args)
        {
            int beesCount = int.Parse(Console.ReadLine());
            int bearHealth = int.Parse(Console.ReadLine());
            int bearAttack = int.Parse(Console.ReadLine());

            int beesHealth = 1;
            int beesAttack = 5;
            while (bearHealth > 0)
            {
                beesCount = beesCount - bearAttack;
                bearHealth -= beesCount * beesAttack;
                if (beesCount < 100)
                {
                    if (beesCount < 0)
                    {
                        beesCount = 0;
                    }
                    Console.WriteLine($"The bear stole the honey! Bees left {beesCount}.");
                    break;
                }
            }
            if (bearHealth <= 0)
            {
                Console.WriteLine($"Beehive won! Bees left {beesCount}.");
            }
        }
    }
}
