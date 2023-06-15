using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using uygulama.simsek.dto.Tenants;
using uygulama.simsek.services.Interfaces;

namespace uygulama.simsek.web.Controllers
{
    [Route("api/tenant")]
    [ApiController]
    public class TenantController : ControllerBase
    {
        private readonly ITenantService tenantService;

        public TenantController(ITenantService tenantService)
        {
            this.tenantService = tenantService;
        }

        [HttpPost()]
        public async Task<IActionResult> InsertTenant([FromBody] TenantDtoRequest model)
        {
            var res = await this.tenantService.InsertTenant(model);
            return Ok(res);
        }

    }
}
