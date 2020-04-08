using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());

            double basketballShoes = tax - (tax * 0.40);
            double basketballDress = basketballShoes - (basketballShoes * 0.20);
            double baskeballBall = basketballDress / 4;
            double basketBallAccessories = baskeballBall / 5;

            double totalMoney = tax + basketballShoes + basketballDress + baskeballBall + basketBallAccessories;
            Console.WriteLine($"{totalMoney:f2}");
        }
    }
}
