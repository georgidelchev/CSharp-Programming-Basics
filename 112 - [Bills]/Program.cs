using System;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double electricityTotal = 0;
            double waterTotal = 0;
            double netTotal = 0;
            double average = 0;
            double others = 0;

            for (int i = 1; i <= months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                electricityTotal += electricity;
                waterTotal += 20;
                netTotal += 15;
            }
            
            double sum = electricityTotal + waterTotal + netTotal;
            others += sum + (sum * 0.20);
            average += electricityTotal + waterTotal + netTotal + others;
            
            Console.WriteLine($"Electricity: {electricityTotal:f2} lv");
            Console.WriteLine($"Water: {waterTotal:f2} lv");
            Console.WriteLine($"Internet: {netTotal:f2} lv");
            Console.WriteLine($"Others: {others:f2} lv");
            Console.WriteLine($"Average: {average / months:f2} lv");
        }
    }
}
