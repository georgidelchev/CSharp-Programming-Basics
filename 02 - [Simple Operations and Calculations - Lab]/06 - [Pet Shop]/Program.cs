using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogsCount = int.Parse(Console.ReadLine());
            int otherAnimalsCount = int.Parse(Console.ReadLine());

            double totalPriceForDogsFood = dogsCount * 2.50;
            double totalPriceForOtherAnimalsFood = otherAnimalsCount * 4.00;

            double totalPrice = totalPriceForDogsFood + totalPriceForOtherAnimalsFood;
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
