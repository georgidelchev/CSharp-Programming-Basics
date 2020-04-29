using System;

namespace ChallengeTheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int mens = int.Parse(Console.ReadLine());
            int womens = int.Parse(Console.ReadLine());
            int maxTables = int.Parse(Console.ReadLine());

            int tablesCounter = 0;

            for (int i = 1; i <= mens; i++)
            {
                for (int j = 1; j <= womens; j++)
                {
                    Console.Write($"({i} <-> {j}) ");
                    tablesCounter++;

                    if (tablesCounter == maxTables)
                    {
                        return;
                    }
                }
            }
        }
    }
}
