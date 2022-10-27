namespace Trams.DATA.Entities
{
    public class Vehicle
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public VehicleType VehicleType { get; set; }
        public List<VehicleStop> VehicleStops { get; set; }
        public List<Route> Routes { get; set; }

        public Vehicle()
            => Id = Guid.NewGuid();
        
        public Vehicle(string name, VehicleType vehicleType)
        {
            Id = Guid.NewGuid();
            Name = name;
            VehicleType = vehicleType;
            VehicleStops = new();
            Routes = new();
        }
    }
}
