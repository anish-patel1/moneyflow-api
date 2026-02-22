using MONEY_FLOW_API.IRepository;
using MONEY_FLOW_API.Model;
using Dapper;

namespace MONEY_FLOW_API.Repository
{
    public class CategoriesRepository : ICategoriesRepository
    {
        private readonly DapperContext _context;
        public CategoriesRepository(DapperContext context)
        {
            _context = context;
        }

        #region # COMMON METHODS
        public async Task<Categories> Delete(Categories obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@CategoryId", obj.CategoryId);
            await _context.CustomQueryAsync<Categories>("MF_Categories_Delete", queryParameters);
            return obj;
        }

        public async Task<IEnumerable<Categories>> DropDown(Categories obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", obj.UserId);
            queryParameters.Add("@CategoryType", obj.CategoryType);
            return await _context.CustomQueryAsync<Categories>("MF_Categories_Dropdown", queryParameters);
        }

        public async Task<Categories> Insert(Categories obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", obj.UserId);
            queryParameters.Add("@CategoryName", obj.CategoryName);
            queryParameters.Add("@CategoryType", obj.CategoryType);
            queryParameters.Add("@CreatedBy", obj.CreatedBy);
            await _context.CustomQueryAsync<Categories>("MF_Categories_Insert", queryParameters);
            return obj;
        }

        public async Task<IEnumerable<Categories>> Select(int? id)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@CategoryId", id);
            return await _context.CustomQueryAsync<Categories>("MF_Categories_Select", queryParameters);
        }

        public async Task<IEnumerable<Categories>> SelectAll(Categories obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@UserId", obj.UserId);
            return await _context.CustomQueryAsync<Categories>("MF_Categories_SelectAll", queryParameters);
        }

        public async Task<Categories> Update(Categories obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@CategoryId", obj.CategoryId);
            queryParameters.Add("@CategoryName", obj.CategoryName);
            queryParameters.Add("@CategoryType", obj.CategoryType);
            queryParameters.Add("@UpdatedBy", obj.UpdatedBy);
            await _context.CustomQueryAsync<Categories>("MF_Categories_Update", queryParameters);
            return obj;
        }
        #endregion
    }
}
