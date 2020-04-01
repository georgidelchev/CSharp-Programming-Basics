using System;

namespace TheMostPowerfulWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            
            double bestPoints = double.MinValue;
            string bestWord = "";

            while (word != "End of words")
            {
                double currentPoints = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    currentPoints += word[i];                
                }
                if (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u' || word[0] == 'y' || word[0] == 'A' || word[0] == 'E' || word[0] == 'I' || word[0] == 'O' || word[0] == 'U' || word[0] == 'Y')
                {
                    currentPoints = currentPoints * word.Length;
                }
                else
                {
                    currentPoints = Math.Floor(currentPoints / word.Length);
                }
                if (currentPoints >= bestPoints)
                {
                    bestPoints = currentPoints;
                    bestWord = word;
                }

                word = Console.ReadLine();
            }
            Console.WriteLine($"The most powerful word is {bestWord} - {bestPoints}");
        }
    }
}
