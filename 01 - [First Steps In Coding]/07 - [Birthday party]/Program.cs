using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double roomRent = double.Parse(Console.ReadLine());
            double cakePrice = roomRent * 0.20;
            double drinks = cakePrice - (cakePrice * 0.45);
            double animator = roomRent / 3;
            double totalPrice = roomRent + cakePrice + drinks + animator;
            Console.WriteLine(totalPrice);
        }
    }
}
