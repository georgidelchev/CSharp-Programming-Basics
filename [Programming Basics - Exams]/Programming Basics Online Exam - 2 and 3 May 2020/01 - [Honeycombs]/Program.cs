using System;

namespace Honeycombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int beesCount = int.Parse(Console.ReadLine());
            int flowersCount = int.Parse(Console.ReadLine());

            double honeyCount = beesCount * flowersCount * 0.21;
            double totalHoneycombs = Math.Floor(honeyCount / 100);
            double leftHoney = honeyCount % 100;
            Console.WriteLine($"{totalHoneycombs} honeycombs filled.");
            Console.WriteLine($"{leftHoney:f2} grams of honey left.");

        }
    }
}
