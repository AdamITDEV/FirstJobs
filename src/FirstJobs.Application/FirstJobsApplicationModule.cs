using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FirstJobs.Authorization;

namespace FirstJobs
{
    [DependsOn(
        typeof(FirstJobsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FirstJobsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<FirstJobsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(FirstJobsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
