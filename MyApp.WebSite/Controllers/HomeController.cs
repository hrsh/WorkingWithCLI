namespace MyApp.WebSite.Controllers {
    using Microsoft.AspNetCore.Mvc;
    public class HomeController : Controller {
        public IActionResult Index () {
            return View ();
        }
        public IActionResult About () {
            return View ();
        }
        public IActionResult Contact () {
            return View ();
        }
        public IActionResult Error () {
            return View ();
        }
    }
}