using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace FirstJobs.Controllers
{
    public abstract class FirstJobsControllerBase: AbpController
    {
        protected FirstJobsControllerBase()
        {
            LocalizationSourceName = FirstJobsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
