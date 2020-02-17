using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using GolLabs.Configuration.Dto;

namespace GolLabs.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : GolLabsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
