using MONEY_FLOW_API.IRepository;
using MONEY_FLOW_API.IService;
using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.Service
{
    public class BudgetsService : IBudgetsService
    {
        private readonly IBudgetsRepository _budgetsRepository;
        public BudgetsService(IBudgetsRepository budgetsRepository)
        {
            _budgetsRepository = budgetsRepository;
        }

        public async Task<IEnumerable<Budgets>> SelectAll(Budgets obj)
        {
            return await _budgetsRepository.SelectAll(obj);
        }

        public async Task<Budgets> Insert(Budgets obj)
        {
            return await _budgetsRepository.Insert(obj);
        }

        public async Task<Budgets> Delete(Budgets obj)
        {
            return await _budgetsRepository.Delete(obj);
        }

        public async Task<Budgets> AutoGenerate(Budgets obj)
        {
            return await _budgetsRepository.AutoGenerate(obj);
        }
    }
}
