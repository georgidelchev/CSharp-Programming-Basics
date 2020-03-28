using System;

namespace BakingCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());

            double sweetsPrice = 1.50;
            double cakesPrice = 7.80;
            double wafflesPrice = 2.30;

            double totalSum = 0;
            
            int bakedCount = 0;


            for (int i = 0; i < peopleCount; i++)
            {
                
                string name = Console.ReadLine();
                int sweetsCount = 0;
                int cakesCount = 0;
                int wafflesCount = 0;
                string sweetType = Console.ReadLine();


                while (sweetType != "Stop baking!")
                { 
                    int bakedSweets = int.Parse(Console.ReadLine());
                    if (sweetType == "cookies")
                    {
                        sweetsCount += bakedSweets;
                    }
                    else if (sweetType == "cakes")
                    {
                        cakesCount += bakedSweets;
                    }
                    else if (sweetType == "waffles")
                    {
                        wafflesCount += bakedSweets;
                    }
                    
                    sweetType = Console.ReadLine();                
                }
                totalSum = totalSum+(sweetsCount * sweetsPrice) + (cakesCount * cakesPrice) + (wafflesCount * wafflesPrice);
                bakedCount = bakedCount+sweetsCount + cakesCount + wafflesCount;
                Console.WriteLine($"{name} baked {sweetsCount} cookies, {cakesCount} cakes and {wafflesCount} waffles.");
            }
            Console.WriteLine($"All bakery sold: {bakedCount}");
            Console.WriteLine($"Total sum for charity: {totalSum:f2} lv.");
        }
    }
}
