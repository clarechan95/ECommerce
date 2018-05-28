using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Clare.ECommerce.Controllers
{
    public abstract class ECommerceControllerBase: AbpController
    {
        protected ECommerceControllerBase()
        {
            LocalizationSourceName = ECommerceConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
