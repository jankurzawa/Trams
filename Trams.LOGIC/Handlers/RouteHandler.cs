namespace Trams.LOGIC.Handlers
{
    public class RouteHandler
    {
        private RouteRepository routeRepository;
        private RouteFactory routeFactory;
        private RouteStopRepository routeStopRepository;

        public RouteHandler()
        {
            routeRepository = new();
            routeFactory = new();
            routeStopRepository = new();
        }

        public Route GetSingle(string name) 
            => routeRepository.GetSingle(r => r.Name == name);
        public List<Route> GetAll() 
            => routeRepository.GetAll();
        public void Delete(Route route)
        {
            routeRepository.Delete(route);
            routeRepository.Save();
        } 
        public void Create(string name, Vehicle vehicle, Stop startingStop, Stop finalStop, TimeSpan time)
        {
            var createdRoute = routeFactory.Create(name, vehicle, time);

            routeRepository.Add(createdRoute);
            routeRepository.Save();

            routeStopRepository.Add(new RouteStop(startingStop, createdRoute, StopStatus.Starting));
            routeStopRepository.Add(new RouteStop(finalStop, createdRoute, StopStatus.Final));
            routeStopRepository.Save();
        }
    }
}
