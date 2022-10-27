namespace Trams.LOGIC.Utils
{
    public static class TimeCalculator
    {
        private static VehicleStopHandler vehicleStopHandler;
        public static TimeSpan GetTimeBetweenStops(Stop firstStop, Stop lastStop)
        {
            if (vehicleStopHandler == null) vehicleStopHandler = new();
            var firstTime = vehicleStopHandler.GetAll(firstStop).First().Departures.OrderBy(d => d.DateTime).FirstOrDefault().DateTime;
            var lastTime = vehicleStopHandler.GetAll(lastStop).First().Departures.OrderBy(d => d.DateTime).FirstOrDefault().DateTime;

            if (firstTime < lastTime) (firstTime, lastTime) = (lastTime, firstTime);
            return new TimeSpan(0, 0, 0) + (firstTime - lastTime);
        }
    }
}
