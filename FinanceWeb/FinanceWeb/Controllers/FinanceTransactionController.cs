using FinanceWeb.Logic;
using Microsoft.AspNetCore.Mvc;

namespace FinanceWeb.Controllers
{
    public class FinanceTransactionController : Controller
    {
        public IActionResult Index()
        {
            return View(FinanceTransactionLogic.GetFinanceTransactions(GlobalContext.User.ID));
        }
    }
}
