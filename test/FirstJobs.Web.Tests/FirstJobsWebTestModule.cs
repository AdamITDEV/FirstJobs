using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FirstJobs.EntityFrameworkCore;
using FirstJobs.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace FirstJobs.Web.Tests
{
    [DependsOn(
        typeof(FirstJobsWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class FirstJobsWebTestModule : AbpModule
    {
        public FirstJobsWebTestModule(FirstJobsEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FirstJobsWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(FirstJobsWebMvcModule).Assembly);
        }
    }
}