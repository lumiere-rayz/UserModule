using Abp.Authorization;
using UserModule.Authorization.Roles;
using UserModule.Authorization.Users;

namespace UserModule.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
