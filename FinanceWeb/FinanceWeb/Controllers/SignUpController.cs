using FinanceWeb.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FinanceWeb.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp(User user)
        {
            return View();
        }
    }
}
