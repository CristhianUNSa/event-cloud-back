using System.Threading.Tasks;
using Sianca.Olh.Configuration.Dto;

namespace Sianca.Olh.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
