using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.IRepository
{
    public interface IAuthRepository
    {
        Task<IEnumerable<User>> User_Validate(string userName);
        Task<User> User_Activity(int? userId, string loginStatus);
    }
}
