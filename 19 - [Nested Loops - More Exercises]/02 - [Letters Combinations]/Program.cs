using System;

namespace LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char missedLetter = char.Parse(Console.ReadLine());

            int combinationsCounter = 0;
            for (char i = letter1; i <= letter2; i++)
            {
                for (char j = letter1; j <= letter2; j++)
                {
                    for (char k = letter1; k <= letter2; k++)
                    {
                        if (i == missedLetter || j == missedLetter || k == missedLetter)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write($"{i}{j}{k} ");
                            combinationsCounter++;
                        }
                    }
                }
            }
            Console.Write(combinationsCounter);
        }
    }
}
