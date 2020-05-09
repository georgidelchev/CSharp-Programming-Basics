using System;

namespace BeehiveRole
{
    class Program
    {
        static void Main(string[] args)
        {
            int intellect = int.Parse(Console.ReadLine());
            int strenght = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            string role = string.Empty;
            if (gender == "female" && strenght >= 80 && intellect >= 80)
            {
                role = "Queen Bee";
            }
            else if (intellect >= 80)
            {
                role = "Repairing Bee";
            }
            else if (intellect >= 60)
            {
                role = "Cleaning Bee";
            }
            else if (gender == "male" && strenght >= 80)
            {
                role = "Drone Bee";
            }
            else if (strenght >= 60)
            {
                role = "Guard Bee";
            }
            else
            {
                role = "Worker Bee";
            }
            Console.WriteLine(role);
        }
    }
}
