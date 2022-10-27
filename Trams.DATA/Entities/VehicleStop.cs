namespace Trams.DATA.Entities
{
    public class VehicleStop
    {
        public Guid Id { get; set; }
        public Vehicle Vehicle { get; set; }
        public Guid VehicleId { get; set; }
        public Stop Stop { get; set; }
        public Guid StopId { get; set; }
        public string Direction { get; set; }
        public List<DepartureTime> Departures { get; set; }
        public int NumberOfStop { get; set; }
        public VehicleStop() { }
        
        public VehicleStop(Vehicle vehicle, Stop stop, int numberOfStop, string direction)
        {
            Id = Guid.NewGuid();
            VehicleId = vehicle.Id;
            StopId = stop.Id;
            Departures = new();
            NumberOfStop = numberOfStop;
            Direction = direction;
        }
    }
}
