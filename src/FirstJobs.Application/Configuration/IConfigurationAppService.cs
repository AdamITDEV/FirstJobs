using System.Threading.Tasks;
using FirstJobs.Configuration.Dto;

namespace FirstJobs.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
