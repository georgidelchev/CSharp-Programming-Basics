using System;

namespace CurrencyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string currencyIn = Console.ReadLine();
            string currencyOut = Console.ReadLine();
            double converted = 0;
            if (currencyIn == "BGN")
            {
                if (currencyOut == "USD")
                {
                    converted = money / 1.79549;
                }
                if (currencyOut == "EUR")
                {
                    converted = money / 1.95583;
                }
                if (currencyOut == "GBP")
                {
                    converted = money / 2.53405;
                }
            }
            else if (currencyIn == "USD")
            {
                if (currencyOut == "BGN")
                {
                    converted = money * 1.79549;
                }
                if (currencyOut == "EUR")
                {
                    converted = money * 0.91801;
                }
                if (currencyOut == "GBP")
                {
                    converted = money * 0.70854;
                }
            }
            else if (currencyIn == "EUR")
            {
                if (currencyOut == "BGN")
                {
                    converted = money * 2.53405;
                }
                if (currencyOut == "USD")
                {
                    converted = money * 1.08930;
                }
                if (currencyOut == "GBP")
                {
                    converted = money * 0.77181;
                }

            }
            else if (currencyIn == "GBP")
            {
                if (currencyOut == "BGN")
                {
                    converted = money * 0.39462;
                }
                if (currencyOut == "EUR")
                {
                    converted = money * 0.77181;
                }
                if (currencyOut == "USD")
                {
                    converted = money * 2.53405 / 1.79549;
                }
            }
            Console.WriteLine($"{converted:f2}");
        }
    }

}
