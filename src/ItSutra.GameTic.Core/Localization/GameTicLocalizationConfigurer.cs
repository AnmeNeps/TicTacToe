using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ItSutra.GameTic.Localization
{
    public static class GameTicLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(GameTicConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(GameTicLocalizationConfigurer).GetAssembly(),
                        "ItSutra.GameTic.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
