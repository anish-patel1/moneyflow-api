using MONEY_FLOW_API.IRepository;
using MONEY_FLOW_API.Model;
using Dapper;

namespace MONEY_FLOW_API.Repository
{
    public class TransactionsRepository : ITransactionsRepository
    {
        private readonly DapperContext _context;
        public TransactionsRepository(DapperContext context)
        {
            _context = context;
        }

        #region # COMMON METHODS
        public async Task<Transactions> Delete(Transactions obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@TransactionId", obj.TransactionId);
            queryParameters.Add("@UserId", obj.UserId);
            await _context.CustomQueryAsync<Transactions>("MF_Transactions_Delete", queryParameters);
            return obj;
        }

        public Task<IEnumerable<Transactions>> DropDown(Transactions obj)
        {
            throw new NotImplementedException();
        }

        public async Task<Transactions> Insert(Transactions obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", obj.UserId);
            queryParameters.Add("@AccountId", obj.AccountId);
            queryParameters.Add("@CategoryId", obj.CategoryId);
            queryParameters.Add("@InstallmentId", obj.InstallmentId);
            queryParameters.Add("@TransactionDate", obj.TransactionDate);
            queryParameters.Add("@Amount", obj.Amount);
            queryParameters.Add("@TransactionType", obj.TransactionType);
            queryParameters.Add("@Description", obj.Description);
            await _context.CustomQueryAsync<Transactions>("MF_Transactions_Insert", queryParameters);
            return obj;
        }

        public async Task<IEnumerable<Transactions>> Select(int? id)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@TransactionId", id);
            return await _context.CustomQueryAsync<Transactions>("MF_Transactions_Select", queryParameters);
        }

        public async Task<IEnumerable<Transactions>> SelectAll(Transactions obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", obj.UserId);
            queryParameters.Add("@FromDate", obj.FromDate);
            queryParameters.Add("@ToDate", obj.ToDate);
            return await _context.CustomQueryAsync<Transactions>("MF_Transactions_SelectAll", queryParameters);
        }

        public async Task<Transactions> Update(Transactions obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@TransactionId", obj.TransactionId);
            queryParameters.Add("@UserId", obj.UserId);
            queryParameters.Add("@AccountId", obj.AccountId);
            queryParameters.Add("@CategoryId", obj.CategoryId);
            queryParameters.Add("@InstallmentId", obj.InstallmentId);
            queryParameters.Add("@TransactionDate", obj.TransactionDate);
            queryParameters.Add("@Amount", obj.Amount);
            queryParameters.Add("@TransactionType", obj.TransactionType);
            queryParameters.Add("@Description", obj.Description);
            await _context.CustomQueryAsync<Transactions>("MF_Transactions_Update", queryParameters);
            return obj;
        }
        #endregion
    }
}
