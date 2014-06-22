using System.Web.Mvc;

namespace MySpaProject.WebMpa.Controllers
{
    public class AboutController : MySpaProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}