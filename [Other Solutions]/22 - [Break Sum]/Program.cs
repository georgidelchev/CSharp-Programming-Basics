using System;

namespace BreakSum
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            for (int i = 1; i <= 3; i++)
            {
                if (flag == false)
                {
                    for (int j = 3; j >= 1; j--)
                    {
                        if (i + j == 2)
                        {
                            flag = true;
                            break;
                        }
                        Console.WriteLine($"{i} {j}");
                    }
                }

            }
        }
    }
}
