using Abp.Authorization;
using ItSutra.GameTic.Authorization.Roles;
using ItSutra.GameTic.Authorization.Users;

namespace ItSutra.GameTic.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
