using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ItSutra.GameTic.Configuration.Dto;

namespace ItSutra.GameTic.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : GameTicAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
