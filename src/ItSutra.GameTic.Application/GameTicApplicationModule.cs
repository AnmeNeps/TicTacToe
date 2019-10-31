using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ItSutra.GameTic.Authorization;

namespace ItSutra.GameTic
{
    [DependsOn(
        typeof(GameTicCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class GameTicApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<GameTicAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(GameTicApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
