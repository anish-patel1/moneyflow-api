using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.IRepository
{
    public interface ITransferRepository : IGenericRepository<Transfer>
    {
        Task<IEnumerable<Transfer>> Select(Transfer obj);
    }
}
