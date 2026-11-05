using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.IService
{
    public interface IBudgetsService
    {
        Task<IEnumerable<Budgets>> SelectAll(Budgets obj);
        Task<Budgets> Insert(Budgets obj);
        Task<Budgets> Delete(Budgets obj);
        Task<Budgets> AutoGenerate(Budgets obj);
    }
}
