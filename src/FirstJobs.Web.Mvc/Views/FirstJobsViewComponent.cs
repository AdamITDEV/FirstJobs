using Abp.AspNetCore.Mvc.ViewComponents;

namespace FirstJobs.Web.Views
{
    public abstract class FirstJobsViewComponent : AbpViewComponent
    {
        protected FirstJobsViewComponent()
        {
            LocalizationSourceName = FirstJobsConsts.LocalizationSourceName;
        }
    }
}
