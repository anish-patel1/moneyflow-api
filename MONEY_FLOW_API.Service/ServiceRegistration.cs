using MONEY_FLOW_API.IService;
using Microsoft.Extensions.DependencyInjection;

namespace MONEY_FLOW_API.Service
{
    public static class ServiceRegistration
    {
        public static void AddServices(this IServiceCollection services)
        {
            #region # ADMIN
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IVersionService, VersionService>();
            #endregion

            #region # SETUP
            services.AddTransient<IAccountsService, AccountsService>();
            services.AddTransient<ICategoriesService, CategoriesService>();
            #endregion

            #region # TRANSACTIONS
            services.AddTransient<ITransactionsService, TransactionsService>();
            services.AddTransient<ITransferService, TransferService>();
            #endregion
        }
    }
}
