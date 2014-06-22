using Abp.Web.Mvc.Controllers;

namespace MySpaProject.WebMpa.Controllers
{
    public abstract class MySpaProjectControllerBase : AbpController
    {
        protected MySpaProjectControllerBase()
        {
            LocalizationSourceName = "MySpaProject";
        }
    }
}