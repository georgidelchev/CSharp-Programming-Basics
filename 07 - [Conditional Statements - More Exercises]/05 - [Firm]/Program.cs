using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int projectHours = int.Parse(Console.ReadLine());
            int projectDays = int.Parse(Console.ReadLine());
            int workersThatTakingOvertime = int.Parse(Console.ReadLine());

            double timeAfterTraining = projectDays - (projectDays * 0.10);
            double time = timeAfterTraining * 8;
            int overtime = workersThatTakingOvertime * (2 * projectDays);
            double totalHours = Math.Floor(time + overtime);

            if (projectHours <= totalHours)
            {
                double hoursLeft = Math.Abs(projectHours - totalHours);
                Console.WriteLine($"Yes!{Math.Floor(hoursLeft)} hours left.");
            }
            else if (projectHours > totalHours)
            {
                double timeNeeded = Math.Abs(totalHours - projectHours);
                Console.WriteLine($"Not enought time!{Math.Floor(timeNeeded)} hours needed.");
            }
        }
    }
}
