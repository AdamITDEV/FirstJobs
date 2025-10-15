using System.Threading.Tasks;
using Abp.Application.Services;
using FirstJobs.Sessions.Dto;

namespace FirstJobs.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
