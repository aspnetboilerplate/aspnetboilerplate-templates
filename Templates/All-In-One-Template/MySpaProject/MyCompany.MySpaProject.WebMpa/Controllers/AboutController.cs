using System.Web.Mvc;

namespace MyCompany.MySpaProject.WebMpa.Controllers
{
    public class AboutController : MySpaProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}