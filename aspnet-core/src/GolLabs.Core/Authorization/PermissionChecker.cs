using Abp.Authorization;
using GolLabs.Authorization.Roles;
using GolLabs.Authorization.Users;

namespace GolLabs.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
