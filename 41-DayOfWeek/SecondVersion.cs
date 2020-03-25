using System;

namespace dOf
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfTheWeek = int.Parse(Console.ReadLine());
            string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            if (dayOfTheWeek >= 1 && dayOfTheWeek <= 7)
            {
                Console.WriteLine(days[dayOfTheWeek-1]);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
