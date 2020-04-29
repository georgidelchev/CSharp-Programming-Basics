using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalCoins = decimal.Parse(Console.ReadLine());
            int counter = 0;

            while (totalCoins > 0)
            {
                totalCoins -= totalCoins >= 2 ? 2 :
                totalCoins >= 1 ? 1 :
                totalCoins >= 0.50m ? 0.50m :
                totalCoins >= 0.20m ? 0.20m :
                totalCoins >= 0.10m ? 0.10m :
                totalCoins >= 0.05m ? 0.05m :
                totalCoins >= 0.02m ? 0.02m :
                totalCoins >= 0.01m ? 0.01m : 0m;
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
