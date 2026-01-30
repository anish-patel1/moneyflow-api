using MONEY_FLOW_API.IRepository;
using MONEY_FLOW_API.IService;
using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.Service
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ICategoriesRepository _categoriesRepository;
        public CategoriesService(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }

        #region # COMMON METHODS
        public async Task<Categories> Delete(Categories obj)
        {
            return await _categoriesRepository.Delete(obj);
        }

        public async Task<IEnumerable<Categories>> DropDown(Categories obj)
        {
            return await _categoriesRepository.DropDown(obj);
        }

        public async Task<Categories> Insert(Categories obj)
        {
            return await _categoriesRepository.Insert(obj);
        }

        public async Task<IEnumerable<Categories>> Select(int? id)
        {
            return await _categoriesRepository.Select(id);
        }

        public async Task<IEnumerable<Categories>> SelectAll(Categories obj)
        {
            return await _categoriesRepository.SelectAll(obj);
        }

        public async Task<Categories> Update(Categories obj)
        {
            return await _categoriesRepository.Update(obj);
        }
        #endregion
    }
}
