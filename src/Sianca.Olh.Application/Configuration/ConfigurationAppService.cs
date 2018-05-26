using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Sianca.Olh.Configuration.Dto;

namespace Sianca.Olh.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : OlhAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
