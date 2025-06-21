using System;
using System.Collections.Generic;

namespace FinancialForecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double presentValue = 10000;
            double growthRate = 0.08;
            int years = 10;

            Console.WriteLine(" Financial Forecasting Tool (Recursive)");
            double futureValue = Forecast.PredictRecursive(presentValue, growthRate, years);
            Console.WriteLine($"Future Value after {years} years: ₹{futureValue:F2}");

            Console.WriteLine("\n Optimized with Memoization:");
            var memo = new Dictionary<int, double>();
            double futureMemo = Forecast.PredictMemo(presentValue, growthRate, years, memo);
            Console.WriteLine($"Memoized Future Value: ₹{futureMemo:F2}");

            Console.ReadLine();
        }
    }
}
