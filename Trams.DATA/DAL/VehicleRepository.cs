namespace Trams.DATA.DAL
{
    public class VehicleRepository : IGetSingler<Vehicle>, IGetAller<Vehicle>
    {
        private TramContext tramContext;

        public VehicleRepository() 
            => tramContext = new();   

        public Vehicle GetSingle(Func<Vehicle, bool> condition) 
            => tramContext.Vehicles.Include(v => v.Routes).Include(v => v.VehicleStops).Where(condition).FirstOrDefault();
        public List<Vehicle> GetAll() 
            => tramContext.Vehicles.ToList();

    }
}
