using System.Threading.Tasks;
using Abp.Application.Services;
using ItSutra.GameTic.Authorization.Accounts.Dto;

namespace ItSutra.GameTic.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
