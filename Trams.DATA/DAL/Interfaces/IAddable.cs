namespace Trams.DATA.DAL.Interfaces
{
    public interface IAddable<T> where T : class
    {
        public void Add(T entity);
    }
}
