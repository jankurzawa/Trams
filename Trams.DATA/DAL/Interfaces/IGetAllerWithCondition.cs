namespace Trams.DATA.DAL.Interfaces
{
    public interface IGetAllerWithCondition<T> where T : class
    {
        public List<T> GetAllWithCondition(Func<T,bool> condition);
    }
}
