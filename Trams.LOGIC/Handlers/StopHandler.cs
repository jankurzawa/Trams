namespace Trams.LOGIC.Handlers
{
    public class StopHandler
    {
        private StopRepository stopRepository;

        public StopHandler() 
            => stopRepository = new();

        public Stop GetSingle(string name) 
            => stopRepository.GetSingle(s => s.Name == name);
        public List<Stop> GetAll() 
            => stopRepository.GetAll();
    }
}
