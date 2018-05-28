using System.Threading.Tasks;
using Abp.Application.Services;
using Clare.ECommerce.Authorization.Accounts.Dto;

namespace Clare.ECommerce.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
