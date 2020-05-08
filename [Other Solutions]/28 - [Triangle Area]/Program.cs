using System;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            int a = Math.Abs(x2 - x3);
            int h = Math.Abs(y2 - y1);
            double area = (double)a * h / 2;
            Console.WriteLine(area);
        }
    }
}
