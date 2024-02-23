using FinanceWeb.Entities;
using FinanceWeb.Logic;
using Microsoft.AspNetCore.Mvc;
using System;

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
            if (!String.IsNullOrEmpty(user.UserName))
            {
                UserLogic.CreateUser(user);
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return RedirectToAction("Index");
            }        
        }
    }
}
