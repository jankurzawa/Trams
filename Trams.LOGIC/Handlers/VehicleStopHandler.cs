namespace Trams.LOGIC.Handlers
{
    public class VehicleStopHandler
    {
        private VehicleStopRepository vehicleStopRepository;

        public VehicleStopHandler() 
            => vehicleStopRepository = new();
        public List<VehicleStop> GetAll(Vehicle vehicle) 
            => vehicleStopRepository.GetAllWithCondition(vs => vs.Vehicle.Id == vehicle.Id).OrderBy(vs => vs.NumberOfStop).ToList();
        public List<VehicleStop> GetAll(Stop stop)
            => vehicleStopRepository.GetAllWithCondition(vs => vs.Stop.Id == stop.Id).OrderBy(vs => vs.Stop.Name).ToList();
    }
}
