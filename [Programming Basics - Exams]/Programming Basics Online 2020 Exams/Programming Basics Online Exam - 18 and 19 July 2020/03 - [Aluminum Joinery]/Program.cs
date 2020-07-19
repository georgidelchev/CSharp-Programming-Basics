using System;

namespace AluminiumJoinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int joineryCount = int.Parse(Console.ReadLine());
            string joineryType = Console.ReadLine();
            string deliveryOrNot = Console.ReadLine();

            if (joineryCount < 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }

            double price = 0;

            if (joineryType == "90X130")
            {
                price = 110 * joineryCount;

                if (joineryCount > 60)
                {
                    price -= price * 0.08;
                }
                else if (joineryCount > 30)
                {
                    price -= price * 0.05;
                }
            }
            else if (joineryType == "100X150")
            {
                price = 140 * joineryCount;

                if (joineryCount > 80)
                {
                    price -= price * 0.10;
                }
                else if (joineryCount > 40)
                {
                    price -= price * 0.06;
                }
            }
            else if (joineryType == "130X180")
            {
                price = 190 * joineryCount;

                if (joineryCount > 50)
                {
                    price -= price * 0.12;
                }
                else if (joineryCount > 20)
                {
                    price -= price * 0.07;
                }
            }
            else if (joineryType == "200X300")
            {
                price = 250 * joineryCount;

                if (joineryCount > 50)
                {
                    price -= price * 0.14;
                }
                else if (joineryCount > 25)
                {
                    price -= price * 0.09;
                }
            }

            if (deliveryOrNot == "With delivery")
            {
                price += 60;
            }

            if (joineryCount > 99)
            {
                price -= price * 0.04;
            }

            Console.WriteLine($"{price:f2} BGN");
        }
    }
}
