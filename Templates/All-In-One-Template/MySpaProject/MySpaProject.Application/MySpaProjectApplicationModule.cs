using System.Reflection;
using Abp.Modules;

namespace MyCompany.MySpaProject
{
    [DependsOn(typeof(MySpaProjectCoreModule))]
    public class MySpaProjectApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
