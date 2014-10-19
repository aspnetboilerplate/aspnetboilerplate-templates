using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Abp.Localization.Sources.Xml;
using Abp.Modules;

namespace MySpaProject.WebMpa
{
    [DependsOn(typeof(MySpaProjectDataModule), typeof(MySpaProjectApplicationModule), typeof(MySpaProjectWebApiModule))]
    public class MySpaProjectWebModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Localization.Sources.Add(
                new XmlLocalizationSource(
                    "MySpaProject",
                    HttpContext.Current.Server.MapPath("~/Localization/MySpaProject")
                    )
                );

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
