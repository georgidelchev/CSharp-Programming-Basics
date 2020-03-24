using System;

namespace FuelsPtTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelQty = double.Parse(Console.ReadLine());
            string discountCard = Console.ReadLine();

            double gasolinePrice = 2.22;
            double dieselPrice = 2.33;
            double gasPrice = 0.93;

            double fuelPrice = 0;
            double discount = 0;

            if (fuelType == "Gasoline")
            {
                fuelPrice = fuelQty * gasolinePrice;
                
                if (discountCard == "Yes")
                {
                    discount = fuelQty * 0.18;
                }
                else
                {
                }
            }
            else if (fuelType == "Diesel")
            {
                fuelPrice = fuelQty * dieselPrice;

                if (discountCard == "Yes")
                {
                    discount = fuelQty * 0.12;
                }
                else
                {
                }
            }
            else if (fuelType == "Gas")
            {
                fuelPrice = fuelQty * gasPrice;
                
                if (discountCard == "Yes")
                {
                    discount = fuelQty * 0.08;
                }
                else
                {
                }
            }

            double totalSum = fuelPrice - discount;
            
            if (fuelQty >= 20 && fuelQty <= 25)
            {
                totalSum = totalSum - (totalSum * 0.08);
            }
            else if (fuelQty > 25)
            {
                totalSum = totalSum - (totalSum * 0.10);
            }

            Console.WriteLine($"{totalSum:f2} lv.");
        }
    }
}
