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
            queryParameters.Add("@InitialPaidMonths", obj.InitialPaidMonths);
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
            queryParameters.Add("@Status", obj.Status);
            queryParameters.Add("@PageSize", obj.PageSize);
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
            queryParameters.Add("@InitialPaidMonths", obj.InitialPaidMonths);
            queryParameters.Add("@StartDate", obj.StartDate);
            queryParameters.Add("@BillingDay", obj.BillingDay);
            queryParameters.Add("@Description", obj.Description);
            await _context.CustomQueryAsync<Installments>("MF_Installments_Update", queryParameters);
            return obj;
        }
        #endregion

        #region # SCHEDULE METHODS
        public async Task<IEnumerable<InstallmentSchedule>> ScheduleSelectAll(InstallmentSchedule obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@InstallmentId", obj.InstallmentId);
            queryParameters.Add("@UserId", obj.UserId);
            return await _context.CustomQueryAsync<InstallmentSchedule>("MF_InstallmentSchedule_SelectAll", queryParameters);
        }

        public async Task<InstallmentSchedule> ScheduleInsert(InstallmentSchedule obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@InstallmentScheduleId", obj.InstallmentScheduleId);
            queryParameters.Add("@InstallmentId", obj.InstallmentId);
            queryParameters.Add("@UserId", obj.UserId);
            queryParameters.Add("@InstallmentNo", obj.InstallmentNo);
            queryParameters.Add("@DueDate", obj.DueDate);
            queryParameters.Add("@OpeningBalance", obj.OpeningBalance);
            queryParameters.Add("@ScheduledAmount", obj.ScheduledAmount);
            queryParameters.Add("@Principal", obj.Principal);
            queryParameters.Add("@Interest", obj.Interest);
            queryParameters.Add("@InterestRate", obj.InterestRate);
            queryParameters.Add("@ExtraCharges", obj.ExtraCharges);
            queryParameters.Add("@ChargesDescription", obj.ChargesDescription);
            queryParameters.Add("@ClosingBalance", obj.ClosingBalance);
            queryParameters.Add("@ScheduleStatus", obj.ScheduleStatus);
            queryParameters.Add("@PaidDate", obj.PaidDate);
            queryParameters.Add("@PaidAmount", obj.PaidAmount);
            queryParameters.Add("@TransactionId", obj.TransactionId);
            queryParameters.Add("@Notes", obj.Notes);
            await _context.CustomQueryAsync<InstallmentSchedule>("MF_InstallmentSchedule_Insert", queryParameters);
            return obj;
        }

        public async Task<InstallmentSchedule> ScheduleBulkInsert(InstallmentSchedule obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@InstallmentId", obj.InstallmentId);
            queryParameters.Add("@UserId", obj.UserId);
            queryParameters.Add("@ScheduleJson", obj.ScheduleJson);
            await _context.CustomQueryAsync<InstallmentSchedule>("MF_InstallmentSchedule_BulkInsert", queryParameters);
            return obj;
        }

        public async Task<InstallmentSchedule> ScheduleDelete(InstallmentSchedule obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@InstallmentScheduleId", obj.InstallmentScheduleId);
            queryParameters.Add("@UserId", obj.UserId);
            await _context.CustomQueryAsync<InstallmentSchedule>("MF_InstallmentSchedule_Delete", queryParameters);
            return obj;
        }
        #endregion
    }
}
