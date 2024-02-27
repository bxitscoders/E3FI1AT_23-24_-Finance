using FinanceWeb.Entities;
using FinanceWeb.Logic;
using Microsoft.AspNetCore.Mvc;

namespace FinanceWeb.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult VerifyLogin(string username)
        {
            User user = UserLogic.GetUser(username);
            GlobalContext.User = user;
            GlobalContext.Credit = AccountLogic.GetAccountCredit(user.ID);
            if (user != null)
                return RedirectToAction("Index", "Home");
            else
                return RedirectToAction("Index");
        }


    }
}
