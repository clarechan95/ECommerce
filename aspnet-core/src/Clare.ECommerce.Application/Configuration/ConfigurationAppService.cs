using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Clare.ECommerce.Configuration.Dto;

namespace Clare.ECommerce.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ECommerceAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
