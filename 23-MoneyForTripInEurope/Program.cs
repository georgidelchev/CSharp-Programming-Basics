using System;

namespace MoneyForTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double chineseYuan = double.Parse(Console.ReadLine());
            double commission = int.Parse(Console.ReadLine());

            double bitcoinToLev = bitcoins * 1168;
            double chineseYuanToDollar = chineseYuan * 0.15;
            double dollarsToLev = chineseYuanToDollar * 1.76;
            double allToEuro = (bitcoinToLev + dollarsToLev) / 1.95;
            double commissionCount = allToEuro * commission / 100;
            double totalMoney = allToEuro - commissionCount;

            Console.WriteLine(totalMoney);
        }
    }
}
