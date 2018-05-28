using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Clare.ECommerce.Roles.Dto;

namespace Clare.ECommerce.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
