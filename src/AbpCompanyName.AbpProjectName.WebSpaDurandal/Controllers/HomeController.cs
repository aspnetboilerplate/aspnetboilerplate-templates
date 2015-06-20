using System.Web.Mvc;

namespace AbpCompanyName.AbpProjectName.WebSpaDurandal.Controllers
{
    public class HomeController : AbpProjectNameControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/shell.cshtml"); //Layout of the durandal application.
        }
	}
}