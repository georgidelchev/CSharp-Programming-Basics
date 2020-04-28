using System;

namespace MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int moviesNumber = int.Parse(Console.ReadLine());

            double rating = 0;
            double bestRating = double.MinValue;
            double minRating = double.MaxValue;
            double ratingSum = 0;
            string bestMovie = "";
            string minMovie = "";

            for (int i = 0; i < moviesNumber; i++)
            {
                string movieName = Console.ReadLine();
                rating = double.Parse(Console.ReadLine());
                if (bestRating < rating)
                {
                    bestRating = rating;
                    bestMovie = movieName;
                }
                if (minRating > rating)
                {
                    minRating = rating;
                    minMovie = movieName;
                }
                ratingSum = ratingSum + rating;
            }
            Console.WriteLine($"{bestMovie} is with highest rating: {bestRating:f1}");
            Console.WriteLine($"{minMovie} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {ratingSum / moviesNumber:f1}");
        }
    }
}
