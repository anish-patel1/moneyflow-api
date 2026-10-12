using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.IService
{
    public interface IReportsService
    {
        Task<IEnumerable<Reports>> MonthlyReconciliation(Reports obj);
        Task<IEnumerable<CategoryReconciliation>> CategoryBreakdown(Reports obj);
    }
}
