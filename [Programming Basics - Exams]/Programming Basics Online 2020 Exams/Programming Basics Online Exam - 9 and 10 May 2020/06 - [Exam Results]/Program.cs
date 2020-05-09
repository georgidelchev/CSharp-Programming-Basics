using System;

namespace ConsoleApp3
{
    class Program
    {

        static void Main(string[] args)
        {
            bool flag = false;
            string name = Console.ReadLine();

            while (name != "Midnight")
            {
                double totPoints = 0;

                for (int i = 1; i <= 6; i++)
                {
                    int points = int.Parse(Console.ReadLine());
                    if (points < 0)
                    {
                        Console.WriteLine($"{name} was cheating!");
                        flag = true;
                        break;
                    }
                    totPoints += points;
                }

                if (flag == false)
                {
                    totPoints = Math.Floor((totPoints / 600) * 100);

                    double grade = totPoints * 0.06;
                    if (grade >= 5)
                    {
                        Console.WriteLine("===================");
                        Console.WriteLine("|   CERTIFICATE   |");
                        Console.WriteLine($"|    {grade:f2}/6.00    |");
                        Console.WriteLine("===================");
                        Console.WriteLine($"Issued to {name}");
                    }
                    else
                    {
                        if (grade < 3.00)
                        {
                            Console.WriteLine($"{name} - 2.00");
                        }
                        else
                        {
                            Console.WriteLine($"{name} - {grade:f2}");
                        }
                    }
                }

                flag = false;
                name = Console.ReadLine();
            }
        }
    }
}
