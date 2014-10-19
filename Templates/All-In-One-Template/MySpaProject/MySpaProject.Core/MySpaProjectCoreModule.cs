using System.Reflection;
using Abp.Modules;

namespace MySpaProject
{
    public class MySpaProjectCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
