using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ItSutra.GameTic.Configuration;

namespace ItSutra.GameTic.Web.Host.Startup
{
    [DependsOn(
       typeof(GameTicWebCoreModule))]
    public class GameTicWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public GameTicWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GameTicWebHostModule).GetAssembly());
        }
    }
}
