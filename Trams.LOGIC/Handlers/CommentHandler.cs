namespace Trams.LOGIC.Handlers
{
    public class CommentHandler
    {
        private CommentRepository commentRepository;
        private CommentFactory commentFactory;
        public CommentHandler()
        {
            commentRepository = new();
            commentFactory = new();
        }
        public List<Comment> GetAllCommentFromStop(Stop stop) 
            => commentRepository.GetAllWithCondition(c => c.StopId == stop.Id);
        public void AddNewComment(string text, Stop stop)
        {
            commentRepository.Add(commentFactory.Create(text, stop));
            commentRepository.Save();
        }
    }
}
