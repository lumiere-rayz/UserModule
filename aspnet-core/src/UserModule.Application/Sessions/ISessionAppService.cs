using System.Threading.Tasks;
using Abp.Application.Services;
using UserModule.Sessions.Dto;

namespace UserModule.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
