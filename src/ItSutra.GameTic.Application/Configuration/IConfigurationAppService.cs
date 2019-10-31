using System.Threading.Tasks;
using ItSutra.GameTic.Configuration.Dto;

namespace ItSutra.GameTic.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
