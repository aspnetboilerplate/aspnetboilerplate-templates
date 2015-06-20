using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace MyCompany.MySpaProject
{
    [DependsOn(typeof(AbpWebApiModule), typeof(MySpaProjectApplicationModule))]
    public class MySpaProjectWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(MySpaProjectApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
