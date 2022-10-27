namespace Trams.LOGIC.Handlers
{
    public class VehicleHandler
    {
        private VehicleRepository vehicleRepository;

        public VehicleHandler() 
            => vehicleRepository = new();

        public Vehicle GetSingle(string name) 
            => vehicleRepository.GetSingle(v => v.Name == name);
        public List<Vehicle> GetAll() 
            => vehicleRepository.GetAll();
    }
}
