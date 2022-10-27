namespace Trams.DATA.Entities
{
    public class Stop
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<VehicleStop> VehicleStops { get; set; }
        public List<Comment> Comments { get; set; }
        public List<RouteStop> RouteStops { get; set; }

        public Stop(string name, string description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            VehicleStops = new();
            Comments = new();
            RouteStops = new();
        }
    }
}
