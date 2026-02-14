using MONEY_FLOW_API.IRepository;
using MONEY_FLOW_API.IService;
using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.Service
{
    public class TransactionsService : ITransactionsService
    {
        private readonly ITransactionsRepository _transactionsRepository;
        public TransactionsService(ITransactionsRepository transactionsRepository)
        {
            _transactionsRepository = transactionsRepository;
        }

        #region # COMMON METHODS
        public async Task<Transactions> Delete(Transactions obj)
        {
            return await _transactionsRepository.Delete(obj);
        }

        public Task<IEnumerable<Transactions>> DropDown(Transactions obj)
        {
            throw new NotImplementedException();
        }

        public async Task<Transactions> Insert(Transactions obj)
        {
            return await _transactionsRepository.Insert(obj);
        }

        public async Task<IEnumerable<Transactions>> Select(int? id)
        {
            return await _transactionsRepository.Select(id);
        }

        public async Task<IEnumerable<Transactions>> SelectAll(Transactions obj)
        {
            return await _transactionsRepository.SelectAll(obj);
        }

        public async Task<Transactions> Update(Transactions obj)
        {
            return await _transactionsRepository.Update(obj);
        }
        #endregion
    }
}
