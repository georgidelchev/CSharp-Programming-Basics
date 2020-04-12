using System;

namespace ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            while (word != "Stop")
            {
                word = Console.ReadLine();
            }
        }
    }
}
