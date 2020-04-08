using System;
namespace EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayerEggs = int.Parse(Console.ReadLine());
            int secondPlayerEggs = int.Parse(Console.ReadLine());
            string winner = Console.ReadLine();
            while (winner != "End of battle")
            {
                if (winner == "one")
                {
                    secondPlayerEggs--;
                }
                else if (winner == "two")
                {
                    firstPlayerEggs--;
                }
                if (firstPlayerEggs == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {secondPlayerEggs} eggs left. ");
                    break;
                }
                else if (secondPlayerEggs == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {firstPlayerEggs} eggs left.");
                    break;
                }
                winner = Console.ReadLine();
            }
            if (winner == "End of battle")
            {
                Console.WriteLine($"Player one has {firstPlayerEggs} eggs left.");
                Console.WriteLine($"Player two has {secondPlayerEggs} eggs left.");
            }
        }
    }
}
