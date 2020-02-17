using System.Threading.Tasks;
using Abp.Application.Services;
using GolLabs.Sessions.Dto;

namespace GolLabs.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
