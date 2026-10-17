using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.IRepository
{
    public interface IBudgetsRepository
    {
        Task<IEnumerable<Budgets>> SelectAll(Budgets obj);
        Task<Budgets> Insert(Budgets obj);
        Task<Budgets> Delete(Budgets obj);
        Task<Budgets> AutoGenerate(Budgets obj);
    }
}
