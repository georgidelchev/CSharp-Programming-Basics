using System;

namespace BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();

            for (int j = int.Parse(start[0].ToString()); j <= int.Parse(end[0].ToString()); j++)
            {
                for (int k = int.Parse(start[1].ToString()); k <= int.Parse(end[1].ToString()); k++)
                {
                    for (int l = int.Parse(start[2].ToString()); l <= int.Parse(end[2].ToString()); l++)
                    {
                        for (int m = int.Parse(start[3].ToString()); m <= int.Parse(end[3].ToString()); m++)
                        {
                            if ((j % 2 != 0) && (k % 2 != 0) && (l % 2 != 0) && (m % 2 != 0))
                            {
                                Console.Write($"{j}{k}{l}{m} ");

                            }
                        }
                    }
                }
            }
        }
    }
}
