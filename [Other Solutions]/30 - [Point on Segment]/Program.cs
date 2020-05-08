using System;

namespace PointOnSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPoint = int.Parse(Console.ReadLine());
            int secondPoint = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            int first = Math.Min(firstPoint, secondPoint);
            int second = Math.Max(firstPoint, secondPoint);

            int left = Math.Abs(first - point);
            int right = Math.Abs(second - point);
            int min = Math.Min(left, right);

            if (point >= first && point <= second)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }

            Console.WriteLine(min);
        }
    }
}
