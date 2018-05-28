using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Clare.ECommerce.Localization
{
    public static class ECommerceLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ECommerceConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ECommerceLocalizationConfigurer).GetAssembly(),
                        "Clare.ECommerce.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
