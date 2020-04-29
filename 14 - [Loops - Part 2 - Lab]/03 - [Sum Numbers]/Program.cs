using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string nums = Console.ReadLine();
            int sum = 0;
            while (nums != "Stop")
            {
                int numbers = int.Parse(nums);
                sum += numbers;
                nums = Console.ReadLine();
            }
            Console.WriteLine(sum);
        }
    }
}
