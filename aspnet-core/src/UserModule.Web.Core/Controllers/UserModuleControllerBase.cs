using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace UserModule.Controllers
{
    public abstract class UserModuleControllerBase: AbpController
    {
        protected UserModuleControllerBase()
        {
            LocalizationSourceName = UserModuleConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
