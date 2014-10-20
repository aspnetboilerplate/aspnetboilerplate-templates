using Abp.Web.Mvc.Controllers;

namespace MySpaProject.WebSpaAngular.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class MySpaProjectControllerBase : AbpController
    {
        protected MySpaProjectControllerBase()
        {
            LocalizationSourceName = "MySpaProject";
        }
    }
}