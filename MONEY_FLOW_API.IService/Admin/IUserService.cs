using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.IService
{
    public interface IUserService : IGenericService<User>
    {
        Task<User> UpdateStatus(User obj);
        Task<User> UnlockUser(User obj);
        Task<IEnumerable<UserLog>> Log_SelectAll(UserLog obj);
    }
}
