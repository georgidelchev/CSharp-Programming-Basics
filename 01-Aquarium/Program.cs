using System;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {

            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double area = lenght * width * hight;
            double capacity = area * 0.001;
            double sand = capacity * percent / 100;
            double remaining = capacity - sand;

            Console.WriteLine($"{remaining:F3}");
        }
    }
}