using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Clare.ECommerce.Authorization;

namespace Clare.ECommerce
{
    [DependsOn(
        typeof(ECommerceCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ECommerceApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ECommerceAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ECommerceApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
