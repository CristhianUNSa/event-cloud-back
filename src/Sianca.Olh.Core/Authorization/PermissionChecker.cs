using Abp.Authorization;
using Sianca.Olh.Authorization.Roles;
using Sianca.Olh.Authorization.Users;

namespace Sianca.Olh.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
