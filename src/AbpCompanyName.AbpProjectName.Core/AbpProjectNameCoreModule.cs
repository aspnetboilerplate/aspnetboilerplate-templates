using System.Reflection;
using Abp.Modules;

namespace AbpCompanyName.AbpProjectName
{
    public class AbpProjectNameCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = AbpProjectNameConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
