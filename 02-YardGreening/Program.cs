using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());

            double pricePerSquareMeter = squareMeters * 7.61;
            double discountPrice = pricePerSquareMeter * 0.18;

            double finalPrice = pricePerSquareMeter - discountPrice;

            Console.WriteLine($"The final price is: {finalPrice:f2} lv.");
            Console.WriteLine($"The discount is: {discountPrice:f2} lv.");
        }
    }
}
