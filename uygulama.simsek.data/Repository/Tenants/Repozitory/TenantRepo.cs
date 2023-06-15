using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using uygulama.simsek.data.Entities.Tenants;
using uygulama.simsek.data.Repository.Tenants.Interfaces;

namespace uygulama.simsek.data.Repository.Tenants.Repozitory
{
    public class TenantRepo: ITenantRepo
    {
        public async Task<Tenant> AddTenantAsync(DbContext dbContext,Tenant tenant)
        {
           await dbContext.Set<Tenant>().AddAsync(tenant);
           await dbContext.SaveChangesAsync();
           return tenant;
        }
    }
}
