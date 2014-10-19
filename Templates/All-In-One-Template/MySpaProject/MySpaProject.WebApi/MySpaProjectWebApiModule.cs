using System.Reflection;
using Abp.Modules;
using Abp.WebApi;

namespace MySpaProject
{
    [DependsOn(typeof(AbpWebApiModule), typeof(MySpaProjectApplicationModule))]
    public class MySpaProjectWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
