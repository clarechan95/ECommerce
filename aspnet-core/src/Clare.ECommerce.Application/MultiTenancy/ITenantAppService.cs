using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Clare.ECommerce.MultiTenancy.Dto;

namespace Clare.ECommerce.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
