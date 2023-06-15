using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using uygulama.simsek.data.DbContextOption;

namespace uygulama.simsek.data.Factories
{
    public class TenantDbContextFactory : ITenantDbContextFactory
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IConfiguration _configuration;

        public TenantDbContextFactory(IServiceProvider serviceProvider, IConfiguration configuration)
        {
            _serviceProvider = serviceProvider;
            _configuration = configuration;
        }
        public DbContext Create()
        {

            // tenant db context type
            string connectionString = _configuration.GetConnectionString("YourConnectionStringName");



            return _serviceProvider.GetService<TenantPosgresqlDbContextOption>();

            // configure strongly typed settings object
            //  services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
            throw new NotImplementedException();
        }
    }
}
