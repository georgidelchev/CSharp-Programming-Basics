using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double triprice = double.Parse(Console.ReadLine());
            double moneySheHave = double.Parse(Console.ReadLine());

            int daysSheSpend = 0;
            int totalDays = 0;

            while (true)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                totalDays++;
                if (action == "spend")
                {
                    daysSheSpend++;
                    moneySheHave -= money;
                    
                    if (moneySheHave < 0)
                    {
                        moneySheHave = 0;
                    }

                    if (daysSheSpend == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{totalDays}");
                        break;
                    }
                }
                else if (action == "save")
                {
                    moneySheHave += money;
                    daysSheSpend = 0;
                }

                if (moneySheHave >= triprice)
                {
                    Console.WriteLine($"You saved the money for {totalDays} days.");
                    break;
                }

            }
        }
    }
}
