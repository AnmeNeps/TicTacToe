using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ItSutra.GameTic.MultiTenancy.Dto;

namespace ItSutra.GameTic.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

