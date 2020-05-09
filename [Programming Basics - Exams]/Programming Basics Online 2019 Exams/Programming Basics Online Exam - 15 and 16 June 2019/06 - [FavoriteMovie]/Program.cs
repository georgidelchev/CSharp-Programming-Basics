using System;

namespace FavoriteMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            int moviesCounter = 0;

            string bestMovie = "";
            int bestPoints = int.MinValue;


            while (true)
            {
                string movieName = Console.ReadLine();
                moviesCounter++;
                if (movieName == "STOP" || moviesCounter >= 7)
                {
                    if (moviesCounter > 7)
                    {
                        Console.WriteLine("The limit is reached.");
                        break;
                    }
                    else if (movieName == "STOP")
                    {
                        break;
                    }
                }
                int totalPoints = 0;
                for (int i = 0; i < movieName.Length; i++)
                {

                    if (Char.IsUpper(movieName[i]))
                    {
                        totalPoints += movieName[i] - movieName.Length;
                    }
                    else if (Char.IsLower(movieName[i]))
                    {
                        totalPoints += movieName[i] - 2 * movieName.Length;
                    }
                    else
                    {
                        totalPoints += movieName[i];
                    }
                }
                if (totalPoints > bestPoints)
                {
                    bestPoints = totalPoints;
                    bestMovie = movieName;
                }
            }
            Console.WriteLine($"The best movie for you is {bestMovie} with {bestPoints} ASCII sum.");

        }
    }
}
