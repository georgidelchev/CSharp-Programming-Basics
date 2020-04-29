using System;

namespace SecretDoorLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int hundredsUpperBorder = int.Parse(Console.ReadLine());
            int dozensUpperBorder = int.Parse(Console.ReadLine());
            int onesUpperBorder = int.Parse(Console.ReadLine());

            for (int i = 1; i <= hundredsUpperBorder; i++)
            {
                for (int j = 1; j <= dozensUpperBorder; j++)
                {
                    for (int k = 1; k <= onesUpperBorder; k++)
                    {
                        if ((k % 2 == 0) && (i % 2 == 0))
                        {
                            if (j == 2 || j == 3 || j == 5 || j == 7)
                            {
                                Console.WriteLine($"{i} {j} {k}");
                            }
                        }
                    }
                }
            }
        }
    }
}
