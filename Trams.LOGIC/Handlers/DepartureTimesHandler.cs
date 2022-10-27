namespace Trams.LOGIC.Handlers
{
    public class DepartureTimesHandler
    {
        private DepartureTimeRepository departureTimeRepository;

        public DepartureTimesHandler() 
            => departureTimeRepository = new();

        public List<DepartureTime> GetDeparturesFromStop(Stop stop)
            => departureTimeRepository.GetAllWithCondition(dt => dt.VehicleStop.StopId == stop.Id)
            .Where(dt => dt.DateTime > DateTime.Now.TimeOfDay).OrderBy(dt => dt.DateTime).Take(5).ToList();
    }
}
