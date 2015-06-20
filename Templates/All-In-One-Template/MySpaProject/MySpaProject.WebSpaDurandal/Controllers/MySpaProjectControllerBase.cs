using Abp.Web.Mvc.Controllers;

namespace MyCompany.MySpaProject.WebSpaDurandal.Controllers
{
    public abstract class MySpaProjectControllerBase : AbpController
    {
        protected MySpaProjectControllerBase()
        {
            LocalizationSourceName = MySpaProjectConsts.LocalizationSourceName;
        }
    }
}