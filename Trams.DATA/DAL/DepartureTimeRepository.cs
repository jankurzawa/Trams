namespace Trams.DATA.DAL
{
    public class DepartureTimeRepository : IGetAllerWithCondition<DepartureTime>
    {
        private TramContext tramContext;

        public DepartureTimeRepository() => tramContext = new();

        public List<DepartureTime> GetAllWithCondition(Func<DepartureTime, bool> condition) 
            => tramContext.DepartureTimes.AsNoTracking().Include(dt => dt.VehicleStop.Vehicle).Where(condition).ToList();
    }
}
