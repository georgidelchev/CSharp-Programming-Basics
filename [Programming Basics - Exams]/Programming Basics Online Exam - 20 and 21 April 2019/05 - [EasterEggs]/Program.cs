using System;

namespace EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int paintedEggs = int.Parse(Console.ReadLine());

            int red = 0;
            int orange = 0;
            int blue = 0;
            int green = 0;
            string currentEgg = "";
            int max = int.MinValue;

            for (int i = 1; i <= paintedEggs; i++)
            {
                string eggColor = Console.ReadLine();
                if (eggColor == "red")
                {
                    red++;
                    if (red > max)
                    {
                        max = red;
                        currentEgg = "red";
                    }
                }
                else if (eggColor == "orange")
                {
                    orange++;
                    if (orange > max)
                    {
                        max = orange;
                        currentEgg = "orange";
                    }
                }
                else if (eggColor == "blue")
                {
                    blue++;
                    if (blue > max)
                    {
                        max = blue;
                        currentEgg = "blue";
                    }
                }
                else if (eggColor == "green")
                {
                    green++;
                    if (green > max)
                    {
                        max = green;
                        currentEgg = "green";
                    }
                }

            }
            
            Console.WriteLine($"Red eggs: {red}");
            Console.WriteLine($"Orange eggs: {orange}");
            Console.WriteLine($"Blue eggs: {blue}");
            Console.WriteLine($"Green eggs: {green}");
            Console.WriteLine($"Max eggs: {max} -> {currentEgg}");
        }
    }
}
