using MONEY_FLOW_API.IRepository;
using MONEY_FLOW_API.IService;
using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.Service
{
    public class ReportsService : IReportsService
    {
        private readonly IReportsRepository _reportsRepository;

        public ReportsService(IReportsRepository reportsRepository)
        {
            _reportsRepository = reportsRepository;
        }

        public async Task<IEnumerable<Reports>> MonthlyReconciliation(Reports obj)
        {
            return await _reportsRepository.MonthlyReconciliation(obj);
        }

        public async Task<IEnumerable<CategoryReconciliation>> CategoryBreakdown(Reports obj)
        {
            return await _reportsRepository.CategoryBreakdown(obj);
        }

        public async Task<IEnumerable<YearAtAGlanceItem>> YearAtAGlance(Reports obj)
        {
            return await _reportsRepository.YearAtAGlance(obj);
        }

        public async Task<IEnumerable<SavingsSummaryItem>> SavingsSummary(Reports obj)
        {
            return await _reportsRepository.SavingsSummary(obj);
        }
    }
}
