using Abp.Web.Mvc.Controllers;

namespace AbpCompanyName.AbpProjectName.WebSpaDurandal.Controllers
{
    public abstract class AbpProjectNameControllerBase : AbpController
    {
        protected AbpProjectNameControllerBase()
        {
            LocalizationSourceName = AbpProjectNameConsts.LocalizationSourceName;
        }
    }
}