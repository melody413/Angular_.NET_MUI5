using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using uygulama.simsek.data.Repository.Tenants.Interfaces;
using uygulama.simsek.data.Repository.Tenants.Repozitory;
using uygulama.simsek.services.Common;
using uygulama.simsek.services.Interfaces;

namespace uygulama.simsek.ioc
{
    public static class IoCContainer
    {
        public static IServiceCollection ConfigureIoCContainer(IServiceCollection services, IConfigurationSection connectionStrings)
        {
            //services.AddDbContext<ApplicationDbContext>(options =>
            //{
            //    options.UseSqlServer(connectionStrings.GetValue<string>("DefaultConnection"));
            //});
            //services.AddDbContext<PantheonDbContext>(options =>
            //{
            //    options.UseSqlServer(connectionStrings.GetValue<string>("PantheonConnection"));
            //});


            //Register services
            services.AddScoped<ITenantService, TenantService>();

            // register repositories
            services.AddScoped<ITenantRepository, TenantRepository>();


            return services;
        }
   }
}
