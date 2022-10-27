namespace Trams.DATA.DAL
{
    public class CommentRepository : IAddable<Comment>, ISaveable, IGetAllerWithCondition<Comment>
    {
        private TramContext tramContext;

        public CommentRepository() 
            => tramContext = new();

        public void Add(Comment entity) 
            => tramContext.Comments.Add(entity);

        public List<Comment> GetAllWithCondition(Func<Comment, bool> condition)
            => tramContext.Comments.Where(condition).ToList();

        public void Save() 
            => tramContext.SaveChanges();
    }
}
