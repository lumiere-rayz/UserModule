using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using UserModule.Authorization;

namespace UserModule
{
    [DependsOn(
        typeof(UserModuleCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class UserModuleApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<UserModuleAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(UserModuleApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
