using Abp.Web.Mvc.Controllers;

namespace MySpaProject.WebSpaAngular.Controllers
{
    public abstract class MySpaProjectControllerBase : AbpController
    {
        protected MySpaProjectControllerBase()
        {
            LocalizationSourceName = "MySpaProject";
        }
    }
}