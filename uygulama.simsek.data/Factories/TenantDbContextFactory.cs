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
            string activeDatabase = _configuration.GetConnectionString("TenantDatabaseType");

            switch (activeDatabase)
            {
                case "MSSQL":
                    return _serviceProvider.GetService<TenantSqlDbContextOption>();
                case "PostgreSQL":
                    return _serviceProvider.GetService<TenantPosgresqlDbContextOption>();
                default:
                    throw new InvalidOperationException("Invalid active database type.");
            }
        }
    }
}
