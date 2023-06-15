using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using uygulama.simsek.dto.Tenants;

namespace uygulama.simsek.services.Interfaces
{
    public interface ITenantService
    {
        Task<TenantDto> InsertTenant(TenantDto model);
    }
}
