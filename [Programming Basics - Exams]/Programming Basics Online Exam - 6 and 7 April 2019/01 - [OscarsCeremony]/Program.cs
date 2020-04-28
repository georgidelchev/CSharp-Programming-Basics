using System;

namespace OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double statuePrice = rent - (rent * 0.30);
            double foodPrice = statuePrice - (statuePrice * 0.15);
            double sound = foodPrice / 2;

            double totalSum = statuePrice + foodPrice + sound + rent;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
