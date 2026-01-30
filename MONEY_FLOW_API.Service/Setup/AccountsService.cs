using MONEY_FLOW_API.IRepository;
using MONEY_FLOW_API.IService;
using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.Service
{
    public class AccountsService : IAccountsService
    {
        private readonly IAccountsRepository _accountsRepository;
        public AccountsService(IAccountsRepository accountsRepository)
        {
            _accountsRepository = accountsRepository;
        }

        #region # COMMON METHODS
        public async Task<Accounts> Delete(Accounts obj)
        {
            return await _accountsRepository.Delete(obj);
        }

        public async Task<IEnumerable<Accounts>> DropDown(Accounts obj)
        {
            return await _accountsRepository.DropDown(obj);
        }

        public async Task<Accounts> Insert(Accounts obj)
        {
            return await _accountsRepository.Insert(obj);
        }

        public async Task<IEnumerable<Accounts>> Select(int? id)
        {
            return await _accountsRepository.Select(id);
        }

        public async Task<IEnumerable<Accounts>> SelectAll(Accounts obj)
        {
            return await _accountsRepository.SelectAll(obj);
        }

        public async Task<Accounts> Update(Accounts obj)
        {
            return await _accountsRepository.Update(obj);
        }
        #endregion
    }
}
