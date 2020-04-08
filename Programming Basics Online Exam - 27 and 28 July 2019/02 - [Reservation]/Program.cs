using System;

namespace Reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            int reservationDay = int.Parse(Console.ReadLine());
            int reservationMonth = int.Parse(Console.ReadLine());
            int dayToCome = int.Parse(Console.ReadLine());
            int monthToCome = int.Parse(Console.ReadLine());
            int dayToLeave = int.Parse(Console.ReadLine());
            int monthToLeave = int.Parse(Console.ReadLine());


            double discount = 0;
            double doubleRoomPricePerNight = 30.00;
            if (dayToLeave - dayToCome >= 10)
            {
                doubleRoomPricePerNight = 25.00;
            }
            if (monthToCome - reservationMonth >= 1)
            {
                doubleRoomPricePerNight = 25.00;
                discount = 0.20;
                doubleRoomPricePerNight = doubleRoomPricePerNight - (doubleRoomPricePerNight * discount);
            }

            double totalSum = (dayToLeave - dayToCome) * doubleRoomPricePerNight;

            Console.WriteLine($"Your stay from {dayToCome}/{monthToCome} to {dayToLeave}/{monthToLeave} will cost {totalSum:f2}");
        }
    }
}
