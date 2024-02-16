using Microsoft.AspNetCore.Mvc;

namespace EmptyProjPrac.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FanMail()
        {
            //Write our code here
            return View();
        }
    }
}
