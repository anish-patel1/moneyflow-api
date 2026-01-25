using MONEY_FLOW_API.IRepository;
using MONEY_FLOW_API.IService;
using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.Service
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        public AuthService(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public async Task<IEnumerable<User>> User_Validate(string userName)
        {
            return await _authRepository.User_Validate(userName);
        }

        public async Task<User> User_Activity(int? userId, string loginStatus)
        {
            return await _authRepository.User_Activity(userId, loginStatus);
        }
    }
}
