using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;

namespace MySpaProject
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(MySpaProjectCoreModule))]
    public class MySpaProjectDataModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
