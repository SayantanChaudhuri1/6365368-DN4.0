namespace FinancialForecasting
{
    public class Forecast
    {
        public static double PredictRecursive(double presentValue, double growthRate, int years)
        {
            if (years == 0)
                return presentValue;

            return PredictRecursive(presentValue, growthRate, years - 1) * (1 + growthRate);
        }

        public static double PredictMemo(double presentValue, double growthRate, int years, Dictionary<int, double> memo)
        {
            if (years == 0)
                return presentValue;

            if (memo.ContainsKey(years))
                return memo[years];

            memo[years] = PredictMemo(presentValue, growthRate, years - 1, memo) * (1 + growthRate);
            return memo[years];
        }
    }
}
