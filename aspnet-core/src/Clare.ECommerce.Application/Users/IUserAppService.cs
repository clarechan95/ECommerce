using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Clare.ECommerce.Roles.Dto;
using Clare.ECommerce.Users.Dto;

namespace Clare.ECommerce.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
