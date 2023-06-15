using uygulama.simsek.dto.Tenants;
using uygulama.simsek.services.Interfaces;

namespace uygulama.simsek.services.Common
{
    public class TenantService : ITenantService
    {
        Task<TenantDto> ITenantService.InsertTenant(TenantDto model)
        {
            throw new NotImplementedException();
        }
    }
}
