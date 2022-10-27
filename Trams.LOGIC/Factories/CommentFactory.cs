namespace Trams.LOGIC.Factories
{
    public class CommentFactory
    {
        public Comment Create(string message, Stop stop) => new Comment(message, stop);
    }
}
