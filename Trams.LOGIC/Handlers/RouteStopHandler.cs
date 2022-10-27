namespace Trams.LOGIC.Handlers
{
    public class RouteStopHandler
    {
        private RouteStopRepository routeStopRepository;

        public RouteStopHandler() 
            => routeStopRepository = new();

        public RouteStop GetSingle(RouteStop routeStop) 
            => routeStopRepository.GetSingle(rs => rs.Id == routeStop.Id);
    }
}
