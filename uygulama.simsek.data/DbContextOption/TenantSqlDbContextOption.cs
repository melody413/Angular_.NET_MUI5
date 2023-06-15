using Microsoft.EntityFrameworkCore;

using uygulama.simsek.data.Entities.Tenants;

namespace uygulama.simsek.data.DbContextOption
{
    public class TenantSqlDbContextOption : DbContext
    {
        public TenantSqlDbContextOption(DbContextOptions<TenantSqlDbContextOption> options)
            : base(options)
        {
        }
        public virtual DbSet<Tenant> Tenants { get; set; }
    }
}
