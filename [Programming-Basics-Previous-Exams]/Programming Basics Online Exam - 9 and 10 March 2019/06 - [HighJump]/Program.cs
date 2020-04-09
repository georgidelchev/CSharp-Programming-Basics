using System;

namespace HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine()); // in cm

            int startingHeight = target - 30;
            int totalJumps = 0;
            bool failed = false;
            while (startingHeight <= target)
            {
                for (int i = 0; i < 3; i++)
                {
                    int triedJump = int.Parse(Console.ReadLine());
                    totalJumps++;
                    if (triedJump > startingHeight)
                    {
                        startingHeight = startingHeight + 5;
                        break;
                    }
                    else if (i == 2)
                    {
                        Console.WriteLine($"Tihomir failed at {startingHeight}cm after {totalJumps} jumps.");
                        failed = true;
                        break;
                    }
                }
                if (failed == true)
                {
                    break;
                }

            }
            if (failed == false)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {target}cm after {totalJumps} jumps.");
            }
        }
    }
}
