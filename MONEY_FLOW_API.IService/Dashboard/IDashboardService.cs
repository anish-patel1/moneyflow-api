using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.IService
{
    public interface IDashboardService
    {
        Task<IEnumerable<DashboardSummary>> SummarySelect(int? id);
    }
}
