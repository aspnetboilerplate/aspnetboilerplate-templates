using System.Web.Mvc;

namespace MyCompany.MySpaProject.WebMpa.Controllers
{
    public class HomeController : MySpaProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}