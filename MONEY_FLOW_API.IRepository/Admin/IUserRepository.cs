using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.IRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> UpdateStatus(User obj);
        Task<User> UnlockUser(User obj); 
        Task<IEnumerable<UserLog>> Log_SelectAll(UserLog obj);
    }
}
