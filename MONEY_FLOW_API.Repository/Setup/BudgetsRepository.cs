using Dapper;
using MONEY_FLOW_API.IRepository;
using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.Repository
{
    public class BudgetsRepository : IBudgetsRepository
    {
        private readonly DapperContext _context;
        public BudgetsRepository(DapperContext context)
        {
            _context = context;
        }

        #region # SelectAll
        public async Task<IEnumerable<Budgets>> SelectAll(Budgets obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", obj.UserId);
            queryParameters.Add("@BudgetYear", obj.BudgetYear);
            queryParameters.Add("@BudgetMonth", obj.BudgetMonth);
            return await _context.CustomQueryAsync<Budgets>("MF_Budgets_SelectAll", queryParameters);
        }
        #endregion

        #region # Insert (Upsert)
        public async Task<Budgets> Insert(Budgets obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", obj.UserId);
            queryParameters.Add("@CategoryId", obj.CategoryId);
            queryParameters.Add("@BudgetYear", obj.BudgetYear);
            queryParameters.Add("@BudgetMonth", obj.BudgetMonth);
            queryParameters.Add("@BudgetAmount", obj.BudgetAmount);
            queryParameters.Add("@CreatedBy", obj.CreatedBy);
            await _context.CustomQueryAsync<Budgets>("MF_Budgets_Insert", queryParameters);
            return obj;
        }
        #endregion

        #region # Delete
        public async Task<Budgets> Delete(Budgets obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@BudgetId", obj.BudgetId);
            await _context.CustomQueryAsync<Budgets>("MF_Budgets_Delete", queryParameters);
            return obj;
        }
        #endregion

        #region # AutoGenerate
        public async Task<Budgets> AutoGenerate(Budgets obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", obj.UserId);
            queryParameters.Add("@BudgetYear", obj.BudgetYear);
            queryParameters.Add("@BudgetMonth", obj.BudgetMonth);
            queryParameters.Add("@CreatedBy", obj.CreatedBy);
            await _context.CustomQueryAsync<Budgets>("MF_Budgets_AutoGenerate", queryParameters);
            return obj;
        }
        #endregion
    }
}
