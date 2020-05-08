using System;
using System.Globalization;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string birth = Console.ReadLine();
            string format = "dd-MM-yyyy";
            var daysAfterBirth = DateTime.ParseExact(birth, format, CultureInfo.InvariantCulture);
            daysAfterBirth = daysAfterBirth.AddDays(1000);
            Console.WriteLine(daysAfterBirth.ToString(format));
        }
    }
}
