using Abp.Web.Mvc.Controllers;

namespace MySpaProject.WebSpaDurandal.Controllers
{
    public abstract class MySpaProjectControllerBase : AbpController
    {
        protected MySpaProjectControllerBase()
        {
            LocalizationSourceName = "MySpaProject";
        }
    }
}