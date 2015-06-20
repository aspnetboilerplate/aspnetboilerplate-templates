using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace AbpCompanyName.AbpProjectName
{
    [DependsOn(typeof(AbpWebApiModule), typeof(AbpProjectNameApplicationModule))]
    public class AbpProjectNameWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(AbpProjectNameApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
