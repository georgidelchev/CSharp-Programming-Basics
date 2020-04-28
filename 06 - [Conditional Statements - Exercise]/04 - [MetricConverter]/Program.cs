using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double valueToConvert = double.Parse(Console.ReadLine());
            string metricIn = Console.ReadLine();
            string metricOut = Console.ReadLine();

            double converted = 0;

            if (metricIn == "m")
            {
                if (metricOut == "cm")
                {
                    converted = valueToConvert * 100;
                }
                if (metricOut == "mm")
                {
                    converted = valueToConvert * 1000;
                }
            }
            if (metricIn == "cm")
            {
                if (metricOut == "m")
                {
                    converted = valueToConvert * 0.01;
                }
                if (metricOut == "mm")
                {
                    converted = valueToConvert * 10;
                }
            }
            if (metricIn == "mm")
            {
                if (metricOut == "cm")
                {
                    converted = valueToConvert * 0.1;
                }
                if (metricOut == "m")
                {
                    converted = valueToConvert * 0.001;
                }
            }
            Console.WriteLine($"{converted:f3}");
        }
    }
}
