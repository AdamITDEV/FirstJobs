using Abp.Application.Services;
using FirstJobs.MultiTenancy.Dto;

namespace FirstJobs.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

