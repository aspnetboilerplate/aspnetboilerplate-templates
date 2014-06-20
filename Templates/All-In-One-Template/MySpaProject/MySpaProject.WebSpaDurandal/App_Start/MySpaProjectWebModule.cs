using System;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using Abp.Dependency;
using Abp.Localization;
using Abp.Modules;
using Abp.Startup;
using MySpaProject.WebSpaDurandal.Localization.MySpaProject;

namespace MySpaProject.WebSpaDurandal
{
    public class MySpaProjectWebModule : AbpModule
    {
        public override Type[] GetDependedModules()
        {
            return new[]
                   {
                       typeof(MySpaProjectDataModule),
                       typeof(MySpaProjectWebApiModule)
                   };
        }

        public override void Initialize(IAbpInitializationContext initializationContext)
        {
            base.Initialize(initializationContext);
            IocManager.Instance.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            LocalizationHelper.RegisterSource<MySpaProjectLocalizationSource>();

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
