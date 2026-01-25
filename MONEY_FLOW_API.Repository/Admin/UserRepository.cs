using MONEY_FLOW_API.IRepository;
using MONEY_FLOW_API.Model;
using Dapper;
using System.Data;

namespace MONEY_FLOW_API.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DapperContext _context;

        public UserRepository(DapperContext context)
        {
            _context = context;
        }

        #region # COMMON METHODS
        public async Task<User> Delete(User obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", obj.UserId);
            await _context.CustomQueryAsync<User>("SPA_User_Delete", queryParameters);
            return obj;
        }

        public Task<IEnumerable<User>> DropDown(User obj)
        {
            throw new NotImplementedException();
        }

        public async Task<User> Insert(User obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserName", obj.UserName);
            queryParameters.Add("@UserDisplayName", obj.UserDisplayName);
            queryParameters.Add("@Password", obj.Password);
            queryParameters.Add("@CreatedBy", obj.CreatedBy);
            queryParameters.Add("@IsExist", DbType.Int32, direction: ParameterDirection.Output);
            await _context.CustomQueryAsync<User>("SPA_User_Insert", queryParameters);
            obj.IsExist = queryParameters.Get<int?>("@IsExist");
            return obj;
        }

        public async Task<IEnumerable<User>> Select(int? id)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", id);
            return await _context.CustomQueryAsync<User>("SPA_User_Select", queryParameters);
        }

        public async Task<IEnumerable<User>> SelectAll(User obj)
        {
            return await _context.CustomQueryAsync<User>("SPA_User_SelectAll");
        }

        public async Task<User> Update(User obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", obj.UserId);
            queryParameters.Add("@UserName", obj.UserName);
            queryParameters.Add("@UserDisplayName", obj.UserDisplayName);
            queryParameters.Add("@Password", obj.Password);
            queryParameters.Add("@UpdatedBy", obj.UpdatedBy);
            await _context.CustomQueryAsync<User>("SPA_User_Update", queryParameters);
            return obj;
        }
        #endregion

        #region # UPDATE STATUS
        public async Task<User> UpdateStatus(User obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", obj.UserId);
            queryParameters.Add("@Status", obj.Status);
            await _context.CustomQueryAsync<User>("SPA_User_UpdateStatus", queryParameters);
            return obj;
        }
        #endregion

        #region # UNLOCK STATUS
        public async Task<User> UnlockUser(User obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", obj.UserId);
            await _context.CustomQueryAsync<User>("SPA_User_Unlock", queryParameters);
            return obj;
        }
        #endregion

        #region # USER LOG - SELECT ALL
        public async Task<IEnumerable<UserLog>> Log_SelectAll(UserLog obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", obj.UserId);
            queryParameters.Add("@FromDate", obj.FromDate);
            queryParameters.Add("@ToDate", obj.ToDate);
            return await _context.CustomQueryAsync<UserLog>("SPA_UserLog_SelectAll", queryParameters);
        }
        #endregion
    }
}
