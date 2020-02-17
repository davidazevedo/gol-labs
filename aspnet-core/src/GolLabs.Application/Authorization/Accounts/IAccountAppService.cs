using System.Threading.Tasks;
using Abp.Application.Services;
using GolLabs.Authorization.Accounts.Dto;

namespace GolLabs.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
