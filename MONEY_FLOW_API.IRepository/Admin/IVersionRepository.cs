using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.IRepository
{
    public interface IVersionRepository : IGenericRepository<Versions>
    {
        
        Task<IEnumerable<Versions>> GetLatestVersion();
    }
}
