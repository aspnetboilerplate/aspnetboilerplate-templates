using System.Web.Mvc;

namespace AbpCompanyName.AbpProjectName.WebMpa.Controllers
{
    public class HomeController : AbpProjectNameControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}