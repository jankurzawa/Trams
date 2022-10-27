namespace Trams.DATA.DAL.Interfaces
{
    public interface IGetSingler<T> where T : class
    {
        public T GetSingle(Func<T, bool> condition);
    }
}
