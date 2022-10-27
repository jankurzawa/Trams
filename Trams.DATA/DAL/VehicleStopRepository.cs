namespace Trams.DATA.DAL
{
    public class VehicleStopRepository : IGetAllerWithCondition<VehicleStop>
    {
        private TramContext tramContext;

        public VehicleStopRepository() 
            => tramContext = new();

        public List<VehicleStop> GetAllWithCondition(Func<VehicleStop, bool> condition) 
            => tramContext.VehicleStops.Include(vs => vs.Stop).Include(vs => vs.Vehicle)
                .Include(vs => vs.Departures).Where(condition).ToList();
    }
}
