using System;

namespace EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());


            double totalSum = 0;

            for (int i = 1; i <= clients; i++)
            {
                int items = 0;
                double sum = 0;
                string order = Console.ReadLine();
                while (order != "Finish")
                {
                    if (order == "basket")
                    {
                        sum += 1.50;
                    }
                    else if (order == "wreath")
                    {
                        sum += 3.80;
                    }
                    else if (order == "chocolate bunny")
                    {
                        sum += 7;
                    }
                    items++;
                    order = Console.ReadLine();
                }
                if (items % 2 == 0)
                {
                    sum = sum - (sum * 0.20);
                    totalSum += sum;
                }
                else
                {
                    totalSum += sum;
                }
                Console.WriteLine($"You purchased {items} items for {sum:f2} leva.");
            }
            double averageBill = totalSum / clients;
            Console.WriteLine($"Average bill per client is: {averageBill:f2} leva.");
        }
    }
}
