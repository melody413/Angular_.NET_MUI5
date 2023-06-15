using AutoMapper;

using uygulama.simsek.data.Entities.Tenants;
using uygulama.simsek.dto.Tenants;

namespace uygulama.simsek.automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TenantDtoRequest, Tenant>().ReverseMap();
        }
    }
}
