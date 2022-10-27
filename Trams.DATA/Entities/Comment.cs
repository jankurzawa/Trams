namespace Trams.DATA.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
        public Stop Stop { get; set; }
        public Guid StopId { get; set; }

        public Comment() { }
        
        public Comment(string message, Stop stop)
        {
            Id = Guid.NewGuid();
            Message = message;
            CreatedDate = DateTime.Now;
            StopId = stop.Id;
        }
    }
}
