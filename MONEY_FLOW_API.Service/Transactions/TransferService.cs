using MONEY_FLOW_API.IRepository;
using MONEY_FLOW_API.IService;
using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.Service
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        public TransferService(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }

        #region # COMMON METHODS
        public async Task<Transfer> Delete(Transfer obj)
        {
            return await _transferRepository.Delete(obj);
        }

        public Task<IEnumerable<Transfer>> DropDown(Transfer obj)
        {
            throw new NotImplementedException();
        }

        public async Task<Transfer> Insert(Transfer obj)
        {
            return await _transferRepository.Insert(obj);
        }

        public Task<IEnumerable<Transfer>> Select(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Transfer>> Select(Transfer obj)
        {
            return await _transferRepository.Select(obj);
        }

        public Task<IEnumerable<Transfer>> SelectAll(Transfer obj)
        {
            throw new NotImplementedException();
        }

        public async Task<Transfer> Update(Transfer obj)
        {
            return await _transferRepository.Update(obj);
        }
        #endregion
    }
}
