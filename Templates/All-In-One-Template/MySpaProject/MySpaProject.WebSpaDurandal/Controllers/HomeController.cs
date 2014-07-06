using System.Web.Mvc;

namespace MySpaProject.WebSpaDurandal.Controllers
{
    public class HomeController : MySpaProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}