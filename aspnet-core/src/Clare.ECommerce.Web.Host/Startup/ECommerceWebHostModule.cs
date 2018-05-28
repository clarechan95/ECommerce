using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Clare.ECommerce.Configuration;

namespace Clare.ECommerce.Web.Host.Startup
{
    [DependsOn(
       typeof(ECommerceWebCoreModule))]
    public class ECommerceWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ECommerceWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ECommerceWebHostModule).GetAssembly());
        }
    }
}
