using System;

namespace WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int rowsNumber = int.Parse(Console.ReadLine());
            int placesAtOddRows = int.Parse(Console.ReadLine());

            int totalPlacesCounter = 0;
            for (int i = 'A'; i <= lastSector; i++)
            {
                for (int j = 1; j <= rowsNumber; j++)
                {
                    if (j % 2 != 0)
                    {
                        for (int k = 1; k <= placesAtOddRows; k++)
                        {
                            Console.WriteLine($"{(char)i}{j}{(char)(k + 96)}");
                            totalPlacesCounter++;
                        }
                    }
                    else if (j % 2 == 0)
                    {
                        for (int k = 1; k <= placesAtOddRows + 2; k++)
                        {
                            Console.WriteLine($"{(char)i}{j}{(char)(k + 96)}");
                            totalPlacesCounter++;
                        }
                    }
                }
                rowsNumber++;
            }
            Console.WriteLine($"{totalPlacesCounter}");
        }
    }
}
