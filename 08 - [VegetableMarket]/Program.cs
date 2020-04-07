using System;

namespace BonusTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegKilosPrice = double.Parse(Console.ReadLine());
            double fruitsKilosPrice = double.Parse(Console.ReadLine());
            int vegKilos = int.Parse(Console.ReadLine());
            int fruitsKilos = int.Parse(Console.ReadLine());


            double vegTotalPrice = vegKilosPrice * vegKilos;
            double fruitsTotalPrice = fruitsKilosPrice * fruitsKilos;

            double totalSumInLv = vegTotalPrice + fruitsTotalPrice;
            double totalSumInEuros = totalSumInLv / 1.94;

            Console.WriteLine($"{totalSumInEuros:f2}");
        }
    }
}
