using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int pointsNumber = int.Parse(Console.ReadLine());
            double bonusPoints = 0;

            if (pointsNumber <= 100)
            {
                bonusPoints += 5;
            }
            if (pointsNumber > 100 && pointsNumber < 1000)
            {
                bonusPoints = pointsNumber * 0.20;
            }
            if (pointsNumber > 1000)
            {
                bonusPoints = pointsNumber * 0.10;
            }
            if (pointsNumber % 2 == 0)
            {
                bonusPoints += 1;
            }
            if (pointsNumber % 10 == 5)
            {
                bonusPoints += 2;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(pointsNumber+bonusPoints);
        }
    }
}
