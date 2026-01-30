using MONEY_FLOW_API.IRepository;
using MONEY_FLOW_API.Model;
using Dapper;

namespace MONEY_FLOW_API.Repository
{
    public class AccountsRepository : IAccountsRepository
    {
        private readonly DapperContext _context;
        public AccountsRepository(DapperContext context)
        {
            _context = context;
        }

        #region # COMMON METHODS
        public async Task<Accounts> Delete(Accounts obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@AccountId", obj.AccountId);
            await _context.CustomQueryAsync<Accounts>("MF_Accounts_Delete", queryParameters);
            return obj;
        }

        public async Task<IEnumerable<Accounts>> DropDown(Accounts obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", obj.UserId);
            return await _context.CustomQueryAsync<Accounts>("MF_Accounts_Dropdown", queryParameters);
        }

        public async Task<Accounts> Insert(Accounts obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", obj.UserId);
            queryParameters.Add("@AccountName", obj.AccountName);
            queryParameters.Add("@AccountType", obj.AccountType);
            queryParameters.Add("@CreatedBy", obj.CreatedBy);
            await _context.CustomQueryAsync<Accounts>("MF_Accounts_Insert", queryParameters);
            return obj;
        }

        public async Task<IEnumerable<Accounts>> Select(int? id)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@AccountId", id);
            return await _context.CustomQueryAsync<Accounts>("MF_Accounts_Select", queryParameters);
        }

        public async Task<IEnumerable<Accounts>> SelectAll(Accounts obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", obj.UserId);
            return await _context.CustomQueryAsync<Accounts>("MF_Accounts_SelectAll", queryParameters);
        }

        public async Task<Accounts> Update(Accounts obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@AccountId", obj.AccountId);
            queryParameters.Add("@AccountName", obj.AccountName);
            queryParameters.Add("@AccountType", obj.AccountType);
            queryParameters.Add("@UpdatedBy", obj.UpdatedBy);
            await _context.CustomQueryAsync<Accounts>("MF_Accounts_Update", queryParameters);
            return obj;
        }
        #endregion
    }
}
