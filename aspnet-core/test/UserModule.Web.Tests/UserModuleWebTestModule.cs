using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using UserModule.EntityFrameworkCore;
using UserModule.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace UserModule.Web.Tests
{
    [DependsOn(
        typeof(UserModuleWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class UserModuleWebTestModule : AbpModule
    {
        public UserModuleWebTestModule(UserModuleEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(UserModuleWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(UserModuleWebMvcModule).Assembly);
        }
    }
}