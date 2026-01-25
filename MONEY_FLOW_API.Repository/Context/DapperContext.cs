using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MONEY_FLOW_API.Repository
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string? _connectionString;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);

        #region Common Dapper Methods For SQL Connection
        public async Task<IEnumerable<T>> CustomQueryAsync<T>(string spName, DynamicParameters dynamicParameters)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                return await connection.QueryAsync<T>(spName, dynamicParameters, commandType: CommandType.StoredProcedure);
            }
        }
        #endregion

        #region To call SP without parameters
        public async Task<IEnumerable<T>> CustomQueryAsync<T>(string spName)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                return await connection.QueryAsync<T>(spName, commandType: CommandType.StoredProcedure);
            }
        }
        #endregion

        #region Get Data Set from Sql connection response
        public async Task<DataSet> CustomeExecuteReaderAsync(string spName, DynamicParameters dynamicParameters)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var dataSetReader = await connection.ExecuteReaderAsync(spName, dynamicParameters, commandType: CommandType.StoredProcedure);
                return ConvertDataReaderToDataSet(dataSetReader);
            }
        }
        public DataSet ConvertDataReaderToDataSet(IDataReader data)
        {
            DataSet ds = new DataSet();
            int i = 0;
            while (!data.IsClosed)
            {
                ds.Tables.Add("Table" + (i + 1));
                ds.EnforceConstraints = false;
                ds.Tables[i].Load(data);
                i++;
            }
            return ds;
        }
        #endregion
    }
}
