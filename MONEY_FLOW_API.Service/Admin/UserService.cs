using MONEY_FLOW_API.IRepository;
using MONEY_FLOW_API.IService;
using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        #region # COMMON METHODS
        public async Task<User> Delete(User obj)
        {
            return await _userRepository.Delete(obj);
        }

        public Task<IEnumerable<User>> DropDown(User obj)
        {
            throw new NotImplementedException();
        }

        public async Task<User> Insert(User obj)
        {
            return await _userRepository.Insert(obj);
        }

        public async Task<IEnumerable<User>> Select(int? id)
        {
            return await _userRepository.Select(id);
        }

        public async Task<IEnumerable<User>> SelectAll(User obj)
        {
            return await _userRepository.SelectAll(obj);
        }

        public async Task<User> Update(User obj)
        {
            return await _userRepository.Update(obj);
        }
        #endregion

        #region # OTHER METHODS
        public async Task<User> UpdateStatus(User obj)
        {
            return await _userRepository.UpdateStatus(obj);
        }

        public async Task<User> UnlockUser(User obj)
        {
            return await _userRepository.UnlockUser(obj);
        }

        public async Task<IEnumerable<UserLog>> Log_SelectAll(UserLog obj)
        {
            return await _userRepository.Log_SelectAll(obj);
        }
        #endregion
    }
}
