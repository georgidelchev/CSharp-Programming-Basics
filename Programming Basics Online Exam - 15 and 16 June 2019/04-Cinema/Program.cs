using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            double totalSum = 0;
            int totalPeople = 0;

            while (true)
            {
                double pay = 0;
                string people = Console.ReadLine();
                if (people == "Movie time!")
                {
                    Console.WriteLine($"There are {capacity - totalPeople} seats left in the cinema.");
                    Console.WriteLine($"Cinema income - {totalSum} lv.");
                    break;
                }
                int peopleCount = int.Parse(people);
                totalPeople += peopleCount;
                if (totalPeople > capacity)
                {
                    Console.WriteLine($"The cinema is full.");
                    Console.WriteLine($"Cinema income - {totalSum} lv.");
                    break;
                }
                pay = peopleCount * 5;
                if (peopleCount % 3 == 0)
                {
                    pay = pay - 5;
                }
                totalSum += pay;
                
            }
        }
    }
}
