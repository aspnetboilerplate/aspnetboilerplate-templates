using System;
using Abp.Castle.Logging.Log4Net;
using Abp.Web;
using Castle.Facilities.Logging;

namespace AbpCompanyName.AbpProjectName.WebSpaAngular
{
    public class MvcApplication : AbpWebApplication<AbpProjectNameWebModule>
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
#if DEBUG
            AbpBootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(
                f => f.UseAbpLog4Net().WithConfig(Server.MapPath("log4net.config"))
            );
#else
            AbpBootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(
                f => f.UseAbpLog4Net().WithConfig(Server.MapPath("log4net.Production.config"))
            );
#endif

            base.Application_Start(sender, e);
        }
    }
}
