using Dapper;
using MONEY_FLOW_API.IRepository;
using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.Repository
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly DapperContext _context;
        public DashboardRepository(DapperContext context)
        {
            _context = context;
        }

        #region # SUMMARY SELECT
        public async Task<IEnumerable<DashboardSummary>> SummarySelect(int? id)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", id);
            return await _context.CustomQueryAsync<DashboardSummary>("MF_Dashboard_Summary", queryParameters);
        }
        #endregion
    }
}
