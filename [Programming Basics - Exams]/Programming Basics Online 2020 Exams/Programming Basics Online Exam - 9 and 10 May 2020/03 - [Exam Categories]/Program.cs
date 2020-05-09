using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int difficulty = int.Parse(Console.ReadLine());
            int zav = int.Parse(Console.ReadLine());
            int pages = int.Parse(Console.ReadLine());

            string type = string.Empty;
            if ((difficulty >= 80) && (zav >= 80) && (pages >= 8))
            {
                type = "Legacy";
            }
            else if ((difficulty >= 80) && (zav <= 10))
            {
                type = "Master";
            }
            else if ((zav >= 50) && (pages >= 2))
            {
                type = "Hard";
            }
            else if ((difficulty <= 30) && (pages <= 1))
            {
                type = "Easy";
            }
            else if ((difficulty <= 10))
            {
                type = "Elementary";
            }
            else
            {
                type = "Regular";
            }
            Console.WriteLine(type);
        }
    }
}
