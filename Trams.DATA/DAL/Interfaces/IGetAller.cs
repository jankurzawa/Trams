namespace Trams.DATA.DAL.Interfaces
{
    public interface IGetAller<T> where T : class
    {
        public List<T> GetAll();
    }
}
