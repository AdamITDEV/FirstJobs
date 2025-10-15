using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace FirstJobs.Localization
{
    public static class FirstJobsLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(FirstJobsConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(FirstJobsLocalizationConfigurer).GetAssembly(),
                        "FirstJobs.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
