namespace Trams.DATA.Entities
{
    public class RouteStop
    {
        public Guid Id { get; set; }
        public Stop Stop { get; set; }
        public Guid StopId { get; set; }
        public Route Route { get; set; }
        public Guid RouteId { get; set; }
        public StopStatus Status { get; set; }

        public RouteStop()
            => Id = Guid.NewGuid();
        
        public RouteStop(Stop stop, Route route, StopStatus status)
        {
            Id = Guid.NewGuid();
            StopId = stop.Id;
            RouteId = route.Id;
            Status = status;
        }
    }
}
