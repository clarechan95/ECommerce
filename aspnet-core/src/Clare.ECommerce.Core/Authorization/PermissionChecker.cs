using Abp.Authorization;
using Clare.ECommerce.Authorization.Roles;
using Clare.ECommerce.Authorization.Users;

namespace Clare.ECommerce.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
