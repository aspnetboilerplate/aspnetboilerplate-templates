using System.Reflection;
using Abp.Modules;

namespace MyCompany.MySpaProject
{
    public class MySpaProjectCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
