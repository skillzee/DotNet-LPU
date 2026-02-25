using Microsoft.AspNetCore.Mvc;

namespace MVC_Core_WebApp1.Controllers
{
    public class DummyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Dummy()
        {
            return View();
        }
    }
}
