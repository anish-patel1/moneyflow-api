using MONEY_FLOW_API.IRepository;
using MONEY_FLOW_API.Model;
using Dapper;

namespace MONEY_FLOW_API.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DapperContext _context;

        public AuthRepository(DapperContext context)
        {
            _context = context;
        }

        #region # USER VALIDATE (GET USER DETAILS)
        public async Task<IEnumerable<User>> User_Validate(string userName)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserName", userName);
            return await _context.CustomQueryAsync<User>("SPA_User_Validate", queryParameters);
        }
        #endregion

        #region # USER ACTIVITY (TO LOG LOGIN AND LOG OUT RELATED ACTIVITY)
        public async Task<User> User_Activity(int? userId, string loginStatus)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", userId);
            queryParameters.Add("@LoginStatus", loginStatus);
            await _context.CustomQueryAsync<User>("SPA_User_LoginActivity", queryParameters);
            return null!;
        }
        #endregion
    }
}
