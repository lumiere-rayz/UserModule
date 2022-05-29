using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using UserModule.Configuration;

namespace UserModule.Web.Host.Startup
{
    [DependsOn(
       typeof(UserModuleWebCoreModule))]
    public class UserModuleWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public UserModuleWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(UserModuleWebHostModule).GetAssembly());
        }
    }
}
