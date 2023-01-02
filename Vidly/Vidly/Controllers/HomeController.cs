using System;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    [AllowAnonymous]            //Permite que un usuario no logueado acceda a todas los actions de este controller
    public class HomeController : Controller
    {        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            throw new Exception();

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}