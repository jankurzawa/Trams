namespace Trams.LOGIC.Utils
{
    public static class CostCalculator
    {
        public static decimal GetCostofRoute(TimeSpan time)
        {
            if (time <= new TimeSpan(0, 20, 0)) return 4;
            else if (time > new TimeSpan(0, 20, 0) && time <= new TimeSpan(1, 0, 0)) return 6;
            else if (time > new TimeSpan(1, 0, 0) && time <= new TimeSpan(1, 30, 0)) return 9;
            else return 35;
        }
    }
}
