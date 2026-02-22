using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.IService
{
    public interface ITransferService : IGenericService<Transfer>
    {
        Task<IEnumerable<Transfer>> Select(Transfer obj);
    }
}
