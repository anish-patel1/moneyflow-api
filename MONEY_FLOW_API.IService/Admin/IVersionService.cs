using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.IService
{
    public interface IVersionService : IGenericService<Versions>
    {
        Task<IEnumerable<Versions>> GetLatestVersion();
    }
}
