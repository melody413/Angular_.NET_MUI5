using uygulama.simsek.data.Factories;
using uygulama.simsek.dto.Tenants;
using uygulama.simsek.services.Interfaces;

namespace uygulama.simsek.services.Common
{
    public class TenantService : ITenantService
    {
        private readonly ITenantDbContextFactory tenantDbContextFactory;

        public TenantService(ITenantDbContextFactory tenantDbContextFactory)
        {
            this.tenantDbContextFactory = tenantDbContextFactory;
        }
        Task<TenantDtoRequest> ITenantService.InsertTenant(TenantDtoRequest model)
        {



            throw new NotImplementedException();
        }
    }
}
