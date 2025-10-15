using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace FirstJobs.Authorization
{
    public class FirstJobsAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Users_Activation, L("UsersActivation"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            var contacts = context.CreatePermission(PermissionNames.Pages_Contacts, L("Contacts"));
            contacts.CreateChildPermission(PermissionNames.Pages_Contacts_Create, L("Create"));
            contacts.CreateChildPermission(PermissionNames.Pages_Contacts_Edit, L("Edit"));
            contacts.CreateChildPermission(PermissionNames.Pages_Contacts_Delete, L("Delete"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, FirstJobsConsts.LocalizationSourceName);
        }
    }
}
