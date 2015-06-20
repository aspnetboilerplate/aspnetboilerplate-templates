using System.Web.Mvc;

namespace AbpCompanyName.AbpProjectName.WebSpaAngular.Controllers
{
    public class HomeController : AbpProjectNameControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}