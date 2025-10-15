using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace FirstJobs.Web.Views
{
    public abstract class FirstJobsRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected FirstJobsRazorPage()
        {
            LocalizationSourceName = FirstJobsConsts.LocalizationSourceName;
        }
    }
}
