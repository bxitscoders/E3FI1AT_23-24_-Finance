using FinanceWeb.Logic;
using Microsoft.AspNetCore.Mvc;

namespace FinanceWeb.Controllers
{
    public class FinanceTransactionController : Controller
    {
        public IActionResult Index()
        {
            if (GlobalContext.User != null)
            {
                return View(FinanceTransactionLogic.GetFinanceTransactions(GlobalContext.User.ID));
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
        }
    }
}
