using System;

namespace TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string cityName = Console.ReadLine();
            string extras = Console.ReadLine();
            string vipCard = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double totalSum = 0;

            if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else
            {
                if (days > 7)
                {
                    days = days - 1;
                }

                if (cityName == "Bansko" || cityName == "Borovets")
                {
                    if (extras == "withEquipment")
                    {
                        totalSum = days * 100.00;
                        if (vipCard == "yes")
                        {
                            totalSum = totalSum - (totalSum * 0.10);
                        }
                    }
                    else if (extras == "noEquipment")
                    {
                        totalSum = days * 80.00;
                        if (vipCard == "yes")
                        {
                            totalSum = totalSum - (totalSum * 0.05);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else if (cityName == "Varna" || cityName == "Burgas")
                {
                    if (extras == "withBreakfast")
                    {
                        totalSum = days * 130.00;
                        if (vipCard == "yes")
                        {
                            totalSum = totalSum - (totalSum * 0.12);
                        }
                    }
                    else if (extras == "noBreakfast")
                    {
                        totalSum = days * 100.00;
                        if (vipCard == "yes")
                        {
                            totalSum = totalSum - (totalSum * 0.07);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                if (totalSum > 0)
                {
                    Console.WriteLine($"The price is {totalSum:f2}lv! Have a nice time!");
                }

            }


        }
    }
}
