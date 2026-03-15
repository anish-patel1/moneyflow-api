using Dapper;
using MONEY_FLOW_API.IRepository;
using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.Repository
{
    public class InstallmentsRepository : IInstallmentsRepository
    {
        private readonly DapperContext _context;
        public InstallmentsRepository(DapperContext context)
        {
            _context = context;
        }

        #region # COMMON METHODS
        public async Task<Installments> Delete(Installments obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@InstallmentId", obj.InstallmentId);
            queryParameters.Add("@UserId", obj.UserId);
            await _context.CustomQueryAsync<Installments>("MF_Installments_Delete", queryParameters);
            return obj;
        }

        public async Task<IEnumerable<Installments>> DropDown(Installments obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", obj.UserId);
            return await _context.CustomQueryAsync<Installments>("MF_Installments_Dropdown", queryParameters);
        }

        public async Task<Installments> Insert(Installments obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", obj.UserId);
            queryParameters.Add("@InstallmentName", obj.InstallmentName);
            queryParameters.Add("@TotalAmount", obj.TotalAmount);
            queryParameters.Add("@DurationMonths", obj.DurationMonths);
            queryParameters.Add("@StartDate", obj.StartDate);
            queryParameters.Add("@BillingDay", obj.BillingDay);
            queryParameters.Add("@Description", obj.Description);
            await _context.CustomQueryAsync<Installments>("MF_Installments_Insert", queryParameters);
            return obj;
        }

        public async Task<IEnumerable<Installments>> Select(int? id)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@InstallmentId", id);
            return await _context.CustomQueryAsync<Installments>("MF_Installments_Select", queryParameters);
        }

        public async Task<IEnumerable<Installments>> SelectAll(Installments obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", obj.UserId);
            return await _context.CustomQueryAsync<Installments>("MF_Installments_SelectAll", queryParameters);
        }

        public async Task<Installments> Update(Installments obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@InstallmentId", obj.InstallmentId);
            queryParameters.Add("@UserId", obj.UserId);
            queryParameters.Add("@InstallmentName", obj.InstallmentName);
            queryParameters.Add("@TotalAmount", obj.TotalAmount);
            queryParameters.Add("@DurationMonths", obj.DurationMonths);
            queryParameters.Add("@StartDate", obj.StartDate);
            queryParameters.Add("@BillingDay", obj.BillingDay);
            queryParameters.Add("@Description", obj.Description);
            await _context.CustomQueryAsync<Installments>("MF_Installments_Update", queryParameters);
            return obj;
        }
        #endregion
    }
}
