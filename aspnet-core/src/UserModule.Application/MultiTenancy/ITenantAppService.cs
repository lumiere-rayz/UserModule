using Abp.Application.Services;
using UserModule.MultiTenancy.Dto;

namespace UserModule.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

