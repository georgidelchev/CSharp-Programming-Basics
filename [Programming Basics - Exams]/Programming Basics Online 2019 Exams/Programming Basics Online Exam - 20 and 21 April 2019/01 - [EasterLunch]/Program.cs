using System;

namespace EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBreads = int.Parse(Console.ReadLine());
            int eggs = int.Parse(Console.ReadLine());
            int cookiesKg = int.Parse(Console.ReadLine());

            double totalMoney = easterBreads * 3.20 + ((eggs * 4.35) + cookiesKg * 5.40 + ((eggs * 12) * 0.15));
            Console.WriteLine($"{totalMoney:f2}");
        }
    }
}
