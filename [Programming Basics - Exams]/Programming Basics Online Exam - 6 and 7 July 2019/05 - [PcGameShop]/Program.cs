using System;

namespace PcGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int selledGames = int.Parse(Console.ReadLine());

            int hrCheck = 0;
            int ftCheck = 0;
            int ovwCheck = 0;
            int otherCheck = 0;

            for (int i = 0; i < selledGames; i++)
            {
                string gameName = Console.ReadLine();
                if (gameName == "Hearthstone")
                {
                    hrCheck++;
                }
                else if (gameName == "Fornite")
                {
                    ftCheck++;
                }
                else if (gameName == "Overwatch")
                {
                    ovwCheck++;
                }
                else
                {
                    otherCheck++;
                }
            }
            Console.WriteLine($"Hearthstone - {hrCheck * 1.0 / selledGames * 100:f2}%");
            Console.WriteLine($"Fornite - {ftCheck * 1.0 / selledGames * 100:f2}%");
            Console.WriteLine($"Overwatch - {ovwCheck * 1.0 / selledGames * 100:f2}%");
            Console.WriteLine($"Others - {otherCheck * 1.0 / selledGames * 100:f2}%");
        }
    }
}
