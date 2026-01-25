using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.IService
{
    public interface IAuthService
    {
        Task<IEnumerable<User>> User_Validate(string userName);
        Task<User> User_Activity(int? userId, string loginStatus);
    }
}
