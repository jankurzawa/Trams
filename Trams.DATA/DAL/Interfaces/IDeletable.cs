namespace Trams.DATA.DAL.Interfaces
{
    public interface IDeletable<T> where T : class
    {
        public void Delete(T entity);
    }
}
