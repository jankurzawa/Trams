namespace Trams.DATA.Entities
{
    public class Route
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public TimeSpan Time { get; private set; }
        public Vehicle Vehicle { get; set; }
        public Guid VehicleId { get; set; }
        public List<RouteStop> RouteStops { get; set; }
        public decimal Cost { get; private set; }
        public Route() { }
        
        public Route(string name, Vehicle vehicle, TimeSpan time)
        {
            Id = Guid.NewGuid();
            Name = name;
            VehicleId = vehicle.Id;
            RouteStops = new();
            Time = time;
            Cost = SetCost();
        }

        private decimal SetCost()
        {
            if (Time <= new TimeSpan(0, 20, 0)) return 4;
            else if (Time > new TimeSpan(0, 20, 0) && Time <= new TimeSpan(1, 0, 0)) return 6;
            else if (Time > new TimeSpan(1, 0, 0) && Time <= new TimeSpan(1, 30, 0)) return 9;
            else return 35;
        }
    }
}
