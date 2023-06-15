using AutoMapper;

using uygulama.simsek.data.Entities.Tenants;
using uygulama.simsek.data.Factories;
using uygulama.simsek.data.Repository.Tenants.Interfaces;
using uygulama.simsek.data.Repository.Tenants.Repozitory;
using uygulama.simsek.dto.Tenants;
using uygulama.simsek.services.Interfaces;

namespace uygulama.simsek.services.Common
{
    public class TenantService : ITenantService
    {
        private readonly ITenantDbContextFactory tenantDbContextFactory;
        private readonly IMapper mapper;
        private readonly ITenantRepo tenantRepository;

        public TenantService(ITenantDbContextFactory tenantDbContextFactory, ITenantRepo tenantRepository,
            IMapper mapper)
        {
            this.tenantDbContextFactory = tenantDbContextFactory;
            this.mapper = mapper;
              this.tenantRepository = tenantRepository;
        }
       public async Task<TenantDtoRequest> InsertTenant(TenantDtoRequest tenant)
        {

            using var dbContext = this.tenantDbContextFactory.Create();

            var tenatEnity= this.mapper.Map<Tenant>(tenant);
            var tenantDb= await this.tenantRepository.AddTenantAsync(dbContext, tenatEnity);
            return tenant;

        }
    }
}
