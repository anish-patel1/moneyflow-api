using MONEY_FLOW_API.IRepository;
using MONEY_FLOW_API.IService;
using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.Service
{
    public class VersionService : IVersionService
    {
        private readonly IVersionRepository _versionRepository;
        public VersionService(IVersionRepository versionRepository)
        {
            _versionRepository = versionRepository;
        }

        #region # COMMON METHODS
        public async Task<Versions> Delete(Versions obj)
        {
            return await _versionRepository.Delete(obj);
        }

        public Task<IEnumerable<Versions>> DropDown(Versions obj)
        {
            throw new NotImplementedException();
        }
        public async Task<Versions> Insert(Versions obj)
        {
            return await _versionRepository.Insert(obj);
        }

        public async Task<IEnumerable<Versions>> Select(int? id)
        {
            return await _versionRepository.Select(id);
        }

        public async Task<IEnumerable<Versions>> SelectAll(Versions obj)
        {
            return await _versionRepository.SelectAll(obj);
        }

        public async Task<Versions> Update(Versions obj)
        {
            return await _versionRepository.Update(obj);
        }
        #endregion

        #region # GET LATEST VERSION
        public async Task<IEnumerable<Versions>> GetLatestVersion()
        {
            return await _versionRepository.GetLatestVersion();
        }

        public Task<User> UpdateStatus(User obj)
        {
            throw new NotImplementedException();
        }

        public Task<User> UnlockUser(User obj)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
