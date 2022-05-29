using System.Threading.Tasks;
using UserModule.Configuration.Dto;

namespace UserModule.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
