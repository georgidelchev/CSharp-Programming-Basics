using System;

namespace Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int detergentCount = int.Parse(Console.ReadLine());
            int detergentQty = detergentCount * 750; //750(ml) is qty


            int dishesCount = 0;
            int potsCount = 0;
            int counter = 0;

            int num = 0;
            string number = " ";

            while (true)
            {
                number = Console.ReadLine();
                if (number == "End")
                {
                    break;
                }
                counter++;
                if (counter % 3 == 0)
                {
                    num = int.Parse(number);
                    potsCount += num;
                    detergentQty -= num * 15;
                }
                else
                {
                    num = int.Parse(number);
                    dishesCount += num;
                    detergentQty -= num * 5;
                }
                if (detergentQty < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(detergentQty)} ml. more necessary!");
                    break;
                }
            }
            if (detergentQty > 0)
            {
                Console.WriteLine($"Detergent was enough!");
                Console.WriteLine($"{dishesCount} dishes and {potsCount} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergentQty} ml.");
            }

        }
    }
}
