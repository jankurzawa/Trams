namespace Trams.DATA.DAL
{
    public class StopRepository : IGetSingler<Stop>, IGetAller<Stop>
    {
        private TramContext tramContext;

        public StopRepository() 
            => tramContext = new();

        public List<Stop> GetAll() 
            => tramContext.Stops.OrderBy(s => s.Name).AsNoTracking().ToList();
        public Stop GetSingle(Func<Stop, bool> condition) 
            => tramContext.Stops.Include(s => s.VehicleStops).Include(s => s.Comments).Where(condition).FirstOrDefault();
    }
}
