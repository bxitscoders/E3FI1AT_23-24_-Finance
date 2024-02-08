using Microsoft.AspNetCore.Mvc;

namespace FinanceWeb.ViewController
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoginClick()
        {
            return View();
        }

    }
}
