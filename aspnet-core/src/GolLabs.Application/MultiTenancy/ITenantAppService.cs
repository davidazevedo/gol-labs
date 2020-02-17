using Abp.Application.Services;
using Abp.Application.Services.Dto;
using GolLabs.MultiTenancy.Dto;

namespace GolLabs.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

