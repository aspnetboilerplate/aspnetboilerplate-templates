using Abp.Web.Mvc.Controllers;

namespace MyMvcProject.Web.Controllers
{
    public abstract class MyMvcProjectControllerBase : AbpController
    {
        protected MyMvcProjectControllerBase()
        {
            LocalizationSourceName = "MyMvcProject";
        }
    }
}