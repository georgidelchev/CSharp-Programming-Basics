using System;

namespace SafePasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int maxPasswordsCount = int.Parse(Console.ReadLine());

            int firstSymbol = 35;
            int secondSymbol = 64;
            string passwordsCombo = String.Empty;
            int passwordsCounter = 0;

            for (int thirdSymbol = 1; thirdSymbol <= firstNumber; thirdSymbol++)
            {
                for (int forthSymbol = 1; forthSymbol <= secondNumber; forthSymbol++)
                {
                    char charFirstSymbol = (char)firstSymbol;
                    char charSecondSymbol = (char)secondSymbol;
                    
                    passwordsCombo += $"" +
                        $"{charFirstSymbol}" +
                        $"{charSecondSymbol}" +
                        $"{thirdSymbol}" +
                        $"{forthSymbol}" +
                        $"{charSecondSymbol}" +
                        $"{charFirstSymbol}|";
                    
                    passwordsCounter++;

                    if (passwordsCounter >= maxPasswordsCount)
                    {
                        Console.WriteLine(passwordsCombo);
                        return;
                    }
                    
                    firstSymbol++;
                    secondSymbol++;
                    
                    if (firstSymbol > 55)
                    {
                        firstSymbol = 35;
                    }
                    if (secondSymbol > 96)
                    {
                        secondSymbol = 64;
                    }
                }
            }
            Console.WriteLine(passwordsCombo);
        }
    }
}
