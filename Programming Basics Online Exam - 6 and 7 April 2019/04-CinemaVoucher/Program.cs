using System;

namespace CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int voucherValue = int.Parse(Console.ReadLine());

            int moviePrice = 0;
            int productPrice = 0;
            int movieCounter = 0;
            int productCounter = 0;

            while (true)
            {
                string purchase = Console.ReadLine();
                if (purchase == "End")
                {
                    Console.WriteLine(movieCounter);
                    Console.WriteLine(productCounter);
                    break;
                }
                if (purchase.Length > 8)
                {
                    moviePrice = purchase[0] + purchase[1];
                    if (moviePrice > voucherValue)
                    {
                        Console.WriteLine(movieCounter);
                        Console.WriteLine(productCounter);
                        break;
                    }
                    voucherValue = voucherValue - moviePrice;
                    movieCounter++;
                }



                else if (purchase.Length <= 8)
                {
                    productPrice = purchase[0];
                    if (productPrice > voucherValue)
                    {
                        Console.WriteLine(movieCounter);
                        Console.WriteLine(productCounter);
                        break;
                    }
                    voucherValue = voucherValue - productPrice;
                    productCounter++;
                }
            }
        }
    }
}
