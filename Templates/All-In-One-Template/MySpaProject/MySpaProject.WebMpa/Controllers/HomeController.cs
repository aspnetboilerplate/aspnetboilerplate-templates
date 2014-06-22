using System.Web.Mvc;

namespace MySpaProject.WebMpa.Controllers
{
    public class HomeController : MySpaProjectControllerBase
    {
        public ActionResult Index()
        { 
            return View();
        }
	}
}