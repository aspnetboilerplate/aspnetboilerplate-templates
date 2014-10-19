using System.Web.Mvc;

namespace MySpaProject.WebSpaAngular.Controllers
{
    public class HomeController : MySpaProjectControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml");
        }
	}
}