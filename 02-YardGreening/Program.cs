using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int aquariumVolume = lenght * width * height;
            double totalLitersCanAquariumTake = aquariumVolume * 0.001;
            double percentOfTookArea = percent * 0.1;
            double realLitersThatCanTook = totalLitersCanAquariumTake * (1 - percentOfTookArea);

            Console.WriteLine($"{realLitersThatCanTook:f3}");
        }
    }
}
