using Abp.Authorization;
using FirstJobs.Authorization.Roles;
using FirstJobs.Authorization.Users;

namespace FirstJobs.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
