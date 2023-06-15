using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using uygulama.simsek.data.DbContextOption;
using uygulama.simsek.data.Factories;
using uygulama.simsek.data.Repository.Tenants.Interfaces;
using uygulama.simsek.data.Repository.Tenants.Repozitory;
using uygulama.simsek.services.Common;
using uygulama.simsek.services.Interfaces;

namespace uygulama.simsek.ioc
{
    public static class IoCContainer
    {
        public static IServiceCollection ConfigureIoCContainer(IServiceCollection services, IConfiguration configuration)
        {
            //Register services
            services.AddScoped<ITenantService, TenantService>();

            // register repositories
          services.AddScoped<ITenantRepo, TenantRepo>();

            #region DbContext
            // Configure MSSQL DbContext
            services.AddDbContext<TenantSqlDbContextOption>(options =>
                options.UseSqlServer(configuration.GetConnectionString("TenantSqlConnection")));

            //Configure PostgreSQL DbContext
            services.AddDbContext<TenantPosgresqlDbContextOption>(options =>
                options.UseNpgsql(configuration.GetConnectionString("TenantPostgresqlConnection")));
            // register factory method
            services.AddScoped<ITenantDbContextFactory, TenantDbContextFactory>();
            #endregion
            return services;
        }
   }
}
