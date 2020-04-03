using System;

namespace GameNumberWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPlayerName = Console.ReadLine();
            string secondPlayerName = Console.ReadLine();

            int firstPlayerPoints = 0;
            int secondPlayerPoints = 0;

            while (true)
            {
                string firstPlayer = Console.ReadLine();
                if (firstPlayer == "End of game")
                {
                    Console.WriteLine($"{firstPlayerName} has {firstPlayerPoints} points");
                    Console.WriteLine($"{secondPlayerName} has {secondPlayerPoints} points");
                    break;
                }
                int firstPlayerCard = int.Parse(firstPlayer);
                int secondPlayerCard = int.Parse(Console.ReadLine());
                if (firstPlayerCard == secondPlayerCard)
                {
                    firstPlayerCard = int.Parse(Console.ReadLine());
                    secondPlayerCard = int.Parse(Console.ReadLine());
                    Console.WriteLine("Number wars!");
                    if (firstPlayerCard > secondPlayerCard)
                    {
                        Console.WriteLine($"{firstPlayerName} is winner with {firstPlayerPoints} points");
                    }
                    else if (secondPlayerCard > firstPlayerCard)
                    {
                        Console.WriteLine($"{secondPlayerName} is winner with {secondPlayerPoints} points");
                    }
                    break;
                }
                else if (firstPlayerCard > secondPlayerCard)
                {
                    firstPlayerPoints += firstPlayerCard - secondPlayerCard;
                }
                else if (secondPlayerCard > firstPlayerCard)
                {
                    secondPlayerPoints += secondPlayerCard - firstPlayerCard;
                }
            }
        }
    }
}
