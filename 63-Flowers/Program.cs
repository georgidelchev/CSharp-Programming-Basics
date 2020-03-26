using System;

namespace FlowersShop
{
    class Program
    {
        static void Main(string[] args)

        {
            int chrysanthemumsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int tulipsCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            double chrysanthemumsPrice = 0;
            double rosesPrice = 0;
            double tulipsPrice = 0;
            double totalSum = 0;
            double discount = 0;

            if (season == "Spring" || season == "Summer")
            {
                chrysanthemumsPrice = 2.00;
                rosesPrice = 4.10;
                tulipsPrice = 2.50;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                chrysanthemumsPrice = 3.75;
                rosesPrice = 4.50;
                tulipsPrice = 4.15;
            }

            totalSum = ((chrysanthemumsCount * chrysanthemumsPrice) + (rosesCount * rosesPrice) + (tulipsCount * tulipsPrice));

            if (holiday == "Y")
            {
                totalSum = totalSum + (totalSum * 0.15);
            }
            if (season == "Spring" && tulipsCount >= 7)
            {
                discount = 0.05;
                totalSum = totalSum - (totalSum * discount);
            }
            if (season == "Winter" && rosesCount >= 10)
            {
                discount = 0.10;
                totalSum = totalSum - (totalSum * discount);
            }
            if ((chrysanthemumsCount + rosesCount + tulipsCount) > 20)
            {
                discount = 0.20;
                totalSum = totalSum - (totalSum * discount);
            }

            Console.WriteLine($"{totalSum + 2:f2}");
        }
    }
}
