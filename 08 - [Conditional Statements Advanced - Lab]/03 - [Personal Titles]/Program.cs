using System;

namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            switch (gender)
            {
                case "m":
                    if (age >= 16)
                    {
                        Console.WriteLine("Mr.");
                    }
                    else if (age < 16)
                    {
                        Console.WriteLine("Master");
                    }
                    break;
                case "f":
                    if (age >= 16)
                    {
                        Console.WriteLine("Ms.");
                    }
                    else if (age < 16)
                    {
                        Console.WriteLine("Miss");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
