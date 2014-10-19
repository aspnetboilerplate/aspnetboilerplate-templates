using System.Reflection;
using Abp.Localization;
using Abp.Modules;

namespace MySpaProject
{
    public class MySpaProjectCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.Languages.Add(new LanguageInfo("en", "English", "famfamfam-flag-england", true));
            Configuration.Localization.Languages.Add(new LanguageInfo("tr", "Türkçe", "famfamfam-flag-tr"));
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
