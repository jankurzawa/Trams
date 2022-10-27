namespace Trams.DATA.DAL
{
    public class RouteRepository : IGetAller<Route>, IAddable<Route>, IGetSingler<Route>, IDeletable<Route>, ISaveable
    {
        private TramContext tramContext;

        public RouteRepository() 
            => tramContext = new();

        public void Add(Route entity) 
            => tramContext.Routes.Add(entity);
        public void Delete(Route entity) 
            => tramContext.Routes.Remove(entity);
        public List<Route> GetAll() 
            => tramContext.Routes.ToList();
        public Route GetSingle(Func<Route, bool> condition) 
            => tramContext.Routes.Include(r => r.RouteStops).Include(r => r.Vehicle).Where(condition).FirstOrDefault();
        public void Save() 
            => tramContext.SaveChanges();
    }
}
