using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.IRepository
{
    public interface IInstallmentsRepository : IGenericRepository<Installments>
    {
        Task<IEnumerable<InstallmentSchedule>> ScheduleSelectAll(InstallmentSchedule obj);
        Task<InstallmentSchedule> ScheduleInsert(InstallmentSchedule obj);
        Task<InstallmentSchedule> ScheduleBulkInsert(InstallmentSchedule obj);
        Task<InstallmentSchedule> ScheduleDelete(InstallmentSchedule obj);
    }
}