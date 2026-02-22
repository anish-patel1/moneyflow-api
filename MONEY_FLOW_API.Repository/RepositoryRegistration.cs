using MONEY_FLOW_API.IRepository;
using Microsoft.Extensions.DependencyInjection;

namespace MONEY_FLOW_API.Repository
{
    public static class RepositoryRegistration
    {
        public static void AddRepository(this IServiceCollection services)
        {
            services.AddScoped<DapperContext>();

            #region # ADMIN
            services.AddTransient<IAuthRepository, AuthRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IVersionRepository, VersionRepository>();
            #endregion

            #region # SETUP
            services.AddTransient<IAccountsRepository, AccountsRepository>();
            services.AddTransient<ICategoriesRepository, CategoriesRepository>();
            #endregion

            #region # TRANSACTIONS
            services.AddTransient<ITransactionsRepository, TransactionsRepository>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            #endregion

        }
    }
}
