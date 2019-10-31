using System.Threading.Tasks;
using Abp.Application.Services;
using ItSutra.GameTic.Sessions.Dto;

namespace ItSutra.GameTic.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
