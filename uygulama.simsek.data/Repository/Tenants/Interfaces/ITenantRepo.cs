using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using uygulama.simsek.data.Entities.Tenants;

namespace uygulama.simsek.data.Repository.Tenants.Interfaces
{
    public interface ITenantRepo
    {
        Task<Tenant> AddTenantAsync(DbContext dbContext, Tenant tenant);
    }
}
