using MONEY_FLOW_API.IRepository;
using MONEY_FLOW_API.Model;
using Dapper;

namespace MONEY_FLOW_API.Repository
{
    public class VersionRepository : IVersionRepository
    {
        private readonly DapperContext _context;

        public VersionRepository(DapperContext context)
        {
            _context = context;
        }

        #region # COMMON METHODS
        public async Task<Versions> Delete(Versions obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@VersionId", obj.VersionId);
            await _context.CustomQueryAsync<Versions>("SPA_Version_Delete", queryParameters);
            return obj;
        }

        public Task<IEnumerable<Versions>> DropDown(Versions obj)
        {
            throw new NotImplementedException();
        }

        public async Task<Versions> Insert(Versions obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@ReleaseDate", obj.ReleaseDate);
            queryParameters.Add("@Version", obj.Version);
            queryParameters.Add("@Details", obj.Details);
            queryParameters.Add("@CreatedBy", obj.CreatedBy);
            await _context.CustomQueryAsync<Versions>("SPA_Version_Insert", queryParameters);
            return obj;
        }

        public async Task<IEnumerable<Versions>> Select(int? id)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@VersionId", id);
            return await _context.CustomQueryAsync<Versions>("SPA_Version_Select", queryParameters);
        }

        public async Task<IEnumerable<Versions>> SelectAll(Versions obj)
        {
            return await _context.CustomQueryAsync<Versions>("SPA_Version_SelectAll");
        }

        public async Task<Versions> Update(Versions obj)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@VersionId", obj.VersionId);
            queryParameters.Add("@ReleaseDate", obj.ReleaseDate);
            queryParameters.Add("@Version", obj.Version);
            queryParameters.Add("@Details", obj.Details);
            queryParameters.Add("@UpdatedBy", obj.UpdatedBy);
            await _context.CustomQueryAsync<Versions>("SPA_Version_Update", queryParameters);
            return obj;
        }
        #endregion

        #region # GET LATEST VERSION
        public async Task<IEnumerable<Versions>> GetLatestVersion()
        {
            return await _context.CustomQueryAsync<Versions>("SPA_Version_GetLatest");
        }
        #endregion
    }
}
