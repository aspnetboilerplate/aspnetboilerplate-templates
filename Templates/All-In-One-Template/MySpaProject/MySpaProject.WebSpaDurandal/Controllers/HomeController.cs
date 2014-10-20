using System.Web.Mvc;

namespace MySpaProject.WebSpaDurandal.Controllers
{
    public class HomeController : MySpaProjectControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/shell.cshtml"); //Layout of the durandal application.
        }
	}
}