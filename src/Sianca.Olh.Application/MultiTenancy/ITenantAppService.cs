using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Sianca.Olh.MultiTenancy.Dto;

namespace Sianca.Olh.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
