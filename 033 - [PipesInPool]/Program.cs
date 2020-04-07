using System;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int poolVolume = int.Parse(Console.ReadLine());
            int firstPipe = int.Parse(Console.ReadLine());
            int secondPipe = int.Parse(Console.ReadLine());
            double hoursThatWorkerIsOut = double.Parse(Console.ReadLine());

            double firstPipeIncome = hoursThatWorkerIsOut * firstPipe;
            double secondPipeIncome = hoursThatWorkerIsOut * secondPipe;
            double totalWaterFromPipes = firstPipeIncome + secondPipeIncome;

            if (totalWaterFromPipes <= poolVolume)
            {
                double poolVolumePercents = (totalWaterFromPipes / poolVolume) * 100;
                double firstPipePercents = (firstPipeIncome / totalWaterFromPipes) * 100;
                double secondPipePercents = (secondPipeIncome / totalWaterFromPipes) * 100;
                Console.WriteLine($"The pool is {poolVolumePercents:f2}% full. Pipe 1: {firstPipePercents:f2}%. Pipe 2: {secondPipePercents:f2}%.");
            }
            else if (totalWaterFromPipes > poolVolume)
            {
                double overflowLiters = totalWaterFromPipes - poolVolume;
                Console.WriteLine($"For {hoursThatWorkerIsOut} the pool overflows with {overflowLiters:f2} liters.");
            }
        }
    }
}
