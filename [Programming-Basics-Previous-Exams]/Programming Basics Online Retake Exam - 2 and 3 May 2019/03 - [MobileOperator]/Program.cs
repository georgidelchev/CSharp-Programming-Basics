using System;

namespace MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string count = Console.ReadLine();
            string type = Console.ReadLine();
            string mobileNet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());

            double totalSum = 0;
            double tax = 0;

            if (count == "one")
            {
                if (type == "Small")
                {
                    tax = 9.98;
                }
                else if (type == "Middle")
                {
                    tax = 18.99;
                }
                else if (type == "Large")
                {
                    tax = 25.98;
                }
                else if (type == "ExtraLarge")
                {
                    tax = 35.99;
                }
            }
            else if (count == "two")
            {
                if (type == "Small")
                {
                    tax = 8.58;
                }
                else if (type == "Middle")
                {
                    tax = 17.09;
                }
                else if (type == "Large")
                {
                    tax = 23.59;
                }
                else if (type == "ExtraLarge")
                {
                    tax = 31.79;
                }
            }

            if (mobileNet == "yes")
            {
                if (tax <= 10.00)
                {
                    tax += 5.50;
                }
                else if (tax > 10.00 && tax <= 30.00)
                {
                    tax += 4.35;
                }
                else if (tax > 30.00)
                {
                    tax += 3.85;
                }
            }
            totalSum = tax * months;
            if (count == "two")
            {
                totalSum = totalSum - (totalSum * 0.0375);
            }
            Console.WriteLine($"{totalSum:f2} lv.");
        }
    }
}
