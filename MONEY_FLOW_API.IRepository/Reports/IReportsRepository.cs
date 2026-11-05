using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.IRepository
{
    public interface IReportsRepository
    {
        Task<IEnumerable<Reports>> MonthlyReconciliation(Reports obj);
        Task<IEnumerable<CategoryReconciliation>> CategoryBreakdown(Reports obj);
        Task<IEnumerable<YearAtAGlanceItem>> YearAtAGlance(Reports obj);
        Task<IEnumerable<SavingsSummaryItem>> SavingsSummary(Reports obj);
    }
}
