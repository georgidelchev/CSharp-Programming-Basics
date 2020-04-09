using System;

namespace PaintingEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string eggsSize = Console.ReadLine();
            string eggsColor = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            double totalSum = 0;

            if (eggsSize == "Large")
            {
                if (eggsColor == "Red")
                {
                    totalSum = count * 16;
                }
                else if (eggsColor == "Green")
                {
                    totalSum = count * 12;
                }
                else if (eggsColor == "Yellow")
                {
                    totalSum = count * 9;
                }
            }
            else if (eggsSize == "Medium")
            {
                if (eggsColor == "Red")
                {
                    totalSum = count * 13;
                }
                else if (eggsColor == "Green")
                {
                    totalSum = count * 9;
                }
                else if (eggsColor == "Yellow")
                {
                    totalSum = count * 7;
                }
            }
            else if (eggsSize == "Small")
            {
                if (eggsColor == "Red")
                {
                    totalSum = count * 9;
                }
                else if (eggsColor == "Green")
                {
                    totalSum = count * 8;
                }
                else if (eggsColor == "Yellow")
                {
                    totalSum = count * 5;
                }
            }
            Console.WriteLine($"{totalSum - (totalSum * 0.35):f2} leva.");
        }
    }
}
