using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace AbpCompanyName.AbpProjectName
{
    [DependsOn(typeof(AbpWebApiModule), typeof(AbpProjectNameApplicationModule))]
    public class AbpProjectNameWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(AbpProjectNameApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
