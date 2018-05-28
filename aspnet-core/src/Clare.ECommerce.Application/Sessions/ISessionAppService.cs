using System.Threading.Tasks;
using Abp.Application.Services;
using Clare.ECommerce.Sessions.Dto;

namespace Clare.ECommerce.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
