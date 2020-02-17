using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using GolLabs.Roles.Dto;
using GolLabs.Users.Dto;

namespace GolLabs.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
