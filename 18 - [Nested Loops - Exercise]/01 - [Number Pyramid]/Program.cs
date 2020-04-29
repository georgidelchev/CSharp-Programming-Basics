using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int pyramidNumber = int.Parse(Console.ReadLine());

            int currentNumberInPyramid = 1;
            bool flag = false;

            for (int i = 1; i <= pyramidNumber; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (currentNumberInPyramid > pyramidNumber)
                    {
                        flag = true;
                        break;
                    }
                    Console.Write($"{currentNumberInPyramid} ");
                    currentNumberInPyramid++;
                }
                if (flag == true)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
