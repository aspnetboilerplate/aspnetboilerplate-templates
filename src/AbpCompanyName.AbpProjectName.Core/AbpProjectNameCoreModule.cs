using System.Reflection;
using Abp.Modules;

namespace AbpCompanyName.AbpProjectName
{
    public class AbpProjectNameCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
