using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.IRepository
{
    public interface IDashboardRepository
    {
        Task<IEnumerable<DashboardSummary>> SummarySelect(int? id);
    }
}
