using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            int libraryCapacity = int.Parse(Console.ReadLine());

            int check = 0;

            while (check < libraryCapacity)
            {
                string checkedBook = Console.ReadLine();
                
                if (checkedBook == favoriteBook)
                {
                    Console.WriteLine($"You checked {check} books and found it.");
                    break;
                }
                check++;
            }
            if (check == libraryCapacity)
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {libraryCapacity} books.");
            }

        }
    }
}
