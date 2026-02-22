using MONEY_FLOW_API.IRepository;
using MONEY_FLOW_API.Model;
using Dapper;

namespace MONEY_FLOW_API.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly DapperContext _context;
        public TransferRepository(DapperContext context)
        {
            _context = context;
        }

        #region # COMMON METHODS
        public async Task<Transfer> Delete(Transfer obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@TransferGroupId", obj.TransferGroupId);
            queryParameters.Add("@UserId", obj.UserId);
            await _context.CustomQueryAsync<Transfer>("MF_Transfers_Delete", queryParameters);
            return obj;
        }

        public Task<IEnumerable<Transfer>> DropDown(Transfer obj)
        {
            throw new NotImplementedException();
        }

        public async Task<Transfer> Insert(Transfer obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", obj.UserId);
            queryParameters.Add("@FromAccountId", obj.FromAccountId);
            queryParameters.Add("@ToAccountId", obj.ToAccountId);
            queryParameters.Add("@Amount", obj.Amount);
            queryParameters.Add("@TransferDate", obj.TransferDate);
            queryParameters.Add("@Description", obj.Description);
            await _context.CustomQueryAsync<Transfer>("MF_Transfers_Insert", queryParameters);
            return obj;
        }

        public Task<IEnumerable<Transfer>> Select(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Transfer>> Select(Transfer obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@TransferGroupId", obj.TransferGroupId);
            queryParameters.Add("@UserId", obj.UserId);
            return await _context.CustomQueryAsync<Transfer>("MF_Transfers_Select", queryParameters);
        }

        public Task<IEnumerable<Transfer>> SelectAll(Transfer obj)
        {
            throw new NotImplementedException();
        }

        public async Task<Transfer> Update(Transfer obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@TransferGroupId", obj.TransferGroupId);
            queryParameters.Add("@UserId", obj.UserId);
            queryParameters.Add("@FromAccountId", obj.FromAccountId);
            queryParameters.Add("@ToAccountId", obj.ToAccountId);
            queryParameters.Add("@Amount", obj.Amount);
            queryParameters.Add("@TransferDate", obj.TransferDate);
            queryParameters.Add("@Description", obj.Description);
            await _context.CustomQueryAsync<Transfer>("MF_Transfers_Update", queryParameters);
            return obj;
        }
        #endregion
    }
}
