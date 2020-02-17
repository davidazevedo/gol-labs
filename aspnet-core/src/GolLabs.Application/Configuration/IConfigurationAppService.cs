using System.Threading.Tasks;
using GolLabs.Configuration.Dto;

namespace GolLabs.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
