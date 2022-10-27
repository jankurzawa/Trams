namespace Trams.DATA.Entities
{
    public class DepartureTime
    {
        public Guid Id { get; set; }
        public TimeSpan DateTime { get; set; }
        public VehicleStop VehicleStop { get; set; }
        public Guid VehicleStopId { get; set; }
        public DepartureTime()
            => Id = Guid.NewGuid();
        
        public DepartureTime(TimeSpan dateTime, VehicleStop vehicleStop)
        {
            Id = Guid.NewGuid();
            DateTime = dateTime;
            VehicleStopId = vehicleStop.Id;
        }
    }
}
