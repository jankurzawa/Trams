namespace Trams.DATA.DAL
{
    public class RouteStopRepository : IGetSingler<RouteStop>, IAddable<RouteStop>, ISaveable
    {
        private TramContext tramContext;

        public RouteStopRepository() 
            => tramContext = new();

        public void Add(RouteStop entity) 
            => tramContext.RouteStops.Add(entity);
        public RouteStop GetSingle(Func<RouteStop, bool> condition)
            => tramContext.RouteStops.Include(vs => vs.Stop).Include(vs => vs.Route).Where(condition).FirstOrDefault();
        public void Save() 
            => tramContext.SaveChanges();
    }
}
