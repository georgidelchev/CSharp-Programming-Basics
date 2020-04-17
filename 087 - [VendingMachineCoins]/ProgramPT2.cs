using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double coins = double.Parse(Console.ReadLine());
            double levs = Math.Floor(coins);
            double monets = Math.Round((coins - levs) * 100);
            double counter = 0;

            while (levs > 0)
            {
                if (levs >= 2)
                {
                    counter++;
                    levs -= 2;
                }
                else if (levs >= 1)
                {
                    if (monets > 0)
                    {
                        counter++;
                        levs -= 1;
                    }
                }
            }
            while (monets > 0)
            {
                if (monets >= 50)
                {
                    counter++;
                    monets -= 50;
                }
                else if (monets >= 50)
                {
                    counter++;
                    monets -= 50;
                }
                else if (monets >= 20)
                {
                    counter++;
                    monets -= 20;
                }
                else if (monets >= 10)
                {
                    counter++;
                    monets -= 10;
                }
                else if (monets >= 05)
                {
                    counter++;
                    monets -= 05;
                }
                else if (monets >= 02)
                {
                    counter++;
                    monets -= 02;
                }
                else if (monets >= 01)
                {
                    counter++;
                    monets -= 01;
                    break;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}

