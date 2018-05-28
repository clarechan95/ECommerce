using System.Threading.Tasks;
using Clare.ECommerce.Configuration.Dto;

namespace Clare.ECommerce.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
