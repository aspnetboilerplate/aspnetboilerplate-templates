using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvcProject.Web.Controllers
{
    public class HomeController : MyMvcProjectControllerBase
    {
        public ActionResult Index()
        { 
            return View();
        }
	}
}