using System;

namespace ChangeBureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double yuans = double.Parse(Console.ReadLine());
            double percentForChangeBureau = double.Parse(Console.ReadLine());

            double bitCoinsToLev = bitcoins * 1168;
            double yuansToDollars = yuans * 0.15;
            double dollarToLev = yuansToDollars * 1.76;
            double levaToEur = (bitCoinsToLev + dollarToLev) / 1.95;

            double totalSum = levaToEur - (levaToEur * (percentForChangeBureau / 100));
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
