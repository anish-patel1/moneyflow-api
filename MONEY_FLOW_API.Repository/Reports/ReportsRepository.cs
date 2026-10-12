using Dapper;
using MONEY_FLOW_API.IRepository;
using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.Repository
{
    public class ReportsRepository : IReportsRepository
    {
        private readonly DapperContext _context;

        public ReportsRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Reports>> MonthlyReconciliation(Reports obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", obj.UserId);
            queryParameters.Add("@Year", obj.Year);
            queryParameters.Add("@Month", obj.Month);

            return await _context.CustomQueryAsync<Reports>("MF_Reports_MonthlyReconciliation", queryParameters);
        }

        public async Task<IEnumerable<CategoryReconciliation>> CategoryBreakdown(Reports obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", obj.UserId);
            queryParameters.Add("@Year", obj.Year);
            queryParameters.Add("@Month", obj.Month);

            return await _context.CustomQueryAsync<CategoryReconciliation>("MF_Reports_CategoryBreakdown", queryParameters);
        }
    }
}
