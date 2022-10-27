namespace Trams.LOGIC.Factories
{
    public class RouteFactory
    {
        public Route Create(string name, Vehicle vehicle, TimeSpan time)
            => new Route(name, vehicle, time);
    }
}
