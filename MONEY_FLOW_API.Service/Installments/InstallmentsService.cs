using MONEY_FLOW_API.IRepository;
using MONEY_FLOW_API.IService;
using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.Service
{
    public class InstallmentsService : IInstallmentsService
    {
        private readonly IInstallmentsRepository _installmentsRepository;
        public InstallmentsService(IInstallmentsRepository installmentsRepository)
        {
            _installmentsRepository = installmentsRepository;
        }

        #region # COMMON METHODS
        public async Task<Installments> Delete(Installments obj)
        {
            return await _installmentsRepository.Delete(obj);
        }

        public async Task<IEnumerable<Installments>> DropDown(Installments obj)
        {
            return await _installmentsRepository.DropDown(obj);
        }

        public async Task<Installments> Insert(Installments obj)
        {
            return await _installmentsRepository.Insert(obj);
        }

        public async Task<IEnumerable<Installments>> Select(int? id)
        {
            return await _installmentsRepository.Select(id);
        }

        public async Task<IEnumerable<Installments>> SelectAll(Installments obj)
        {
            return await _installmentsRepository.SelectAll(obj);
        }

        public async Task<Installments> Update(Installments obj)
        {
            return await _installmentsRepository.Update(obj);
        }
        #endregion
    }
}
