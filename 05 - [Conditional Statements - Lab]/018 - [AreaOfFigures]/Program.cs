using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            switch (figure)
            {
                case "square":
                    double a = double.Parse(Console.ReadLine());
                    double squareArea = a * a;
                    Console.WriteLine($"{squareArea:f3}");
                    break;
                case "rectangle":
                    double sideA = double.Parse(Console.ReadLine());
                    double sideB = double.Parse(Console.ReadLine());
                    double rectanbleArea = sideA * sideB;
                    Console.WriteLine($"{rectanbleArea:f3}");
                    break;
                case "circle":
                    double r = double.Parse(Console.ReadLine());
                    double circleArea = Math.PI * r * r;
                    Console.WriteLine($"{circleArea:f3}");
                    break;
                case "triangle":
                    double triangleSideA = double.Parse(Console.ReadLine());
                    double triangleHeight = double.Parse(Console.ReadLine());
                    double triangleArea = triangleSideA * triangleHeight / 2;
                    Console.WriteLine($"{triangleArea:f3}");
                    break;
                default:
                    break;
            }
        }
    }
}
