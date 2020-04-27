﻿using System;

namespace TrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double trapezoidArea = (b1 + b2) * h / 2;

            Console.WriteLine($"{trapezoidArea:f2}");
        }
    }
}
