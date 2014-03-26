using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MyMvcProject.Web.Localization
{
    public class ApplicationLanguageInfo
    {
        public static Dictionary<string, ApplicationLanguageInfo> SupportedLanguages { get; private set; }

        public static ApplicationLanguageInfo CurrentLanguage
        {
            get
            {
                var currentCultureName = Thread.CurrentThread.CurrentUICulture.Name;

                //Try to find exact match
                ApplicationLanguageInfo currentLanguage;
                if (SupportedLanguages.TryGetValue(currentCultureName, out currentLanguage))
                {
                    return currentLanguage;
                }

                //Try to find best match
                currentLanguage = SupportedLanguages.Values.FirstOrDefault(l => currentCultureName.StartsWith(l.Name));
                if (currentLanguage != null)
                {
                    return currentLanguage;
                }

                //Return default
                return SupportedLanguages.Values.FirstOrDefault(l => l.IsDefault);
            }
        }

        static ApplicationLanguageInfo()
        {
            SupportedLanguages =
                new Dictionary<string, ApplicationLanguageInfo>
                {
                    {
                        "en",
                        new ApplicationLanguageInfo
                        {
                            Name = "en",
                            DisplayName = "English",
                            IconClass = "famfamfam-flag-england",
                            IsDefault = true
                        }
                    },
                    {
                        "tr",
                        new ApplicationLanguageInfo
                        {
                            Name = "tr",
                            DisplayName = "Türkçe",
                            IconClass = "famfamfam-flag-tr"
                        }
                    }
                };
        }

        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string IconClass { get; set; }

        public bool IsDefault { get; set; }
    }
}