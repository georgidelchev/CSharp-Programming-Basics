using System;

namespace EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsCount = int.Parse(Console.ReadLine());

            int soldEggs = 0;

            string command = Console.ReadLine();
            while (command != "Close")
            {
                int eggs = int.Parse(Console.ReadLine());

                if (command == "Buy")
                {
                    if (eggs > eggsCount)
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {eggsCount}.");
                        break;
                    }
                    eggsCount -= eggs;
                    soldEggs += eggs;
                }
                else if (command == "Fill")
                {
                    eggsCount += eggs;
                }

                command = Console.ReadLine();

            }

            if (command == "Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{soldEggs} eggs sold.");
            }

        }
    }
}
