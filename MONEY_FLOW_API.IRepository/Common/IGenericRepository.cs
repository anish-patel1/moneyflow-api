namespace MONEY_FLOW_API.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> Select(int? id);
        Task<IEnumerable<T>> SelectAll(T obj);
        Task<T> Insert(T obj);
        Task<T> Update(T obj);
        Task<T> Delete(T obj);
        Task<IEnumerable<T>> DropDown(T obj);
    }
}
