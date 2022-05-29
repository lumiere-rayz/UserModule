﻿using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using UserModule.Configuration.Dto;

namespace UserModule.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : UserModuleAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
