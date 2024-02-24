using FinanceWeb.Entities;
using FinanceWeb.Enum;
using FinanceWeb.Logic;
using FinanceWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceWeb.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Account account = AccountLogic.GetAccountByUserId(GlobalContext.User.ID);
            GlobalContext.AccountId = account.ID;
            return View(account);
        }


        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Stocks()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        

        public IActionResult BuyShare(int id, int amount)
        {
            Possession selectedPossession = PossessionLogic.GetPossessionByShareId(id, GlobalContext.AccountId);
            ShareValue shareValue = ShareValueLogic.GetCurrentShareValueByShareId(id);

            if (GlobalContext.Credit >= shareValue.Value)
            {
                GlobalContext.Credit -= shareValue.Value;
                selectedPossession.Number++;

                AccountLogic.UpdateAccountCreditByUserId(GlobalContext.Credit, GlobalContext.User.ID);
                PossessionLogic.UpdateNumberByShareId(selectedPossession.Number, id, GlobalContext.AccountId);
                FinanceTransactionLogic.NewTransaction(TransactionTypeEnum.Buy, 1, shareValue.ID);
            }
            
            return RedirectToAction("Index");
        }

        public IActionResult SellShare(int id, int amount)
        {
            Possession selectedPossession = PossessionLogic.GetPossessionByShareId(id, GlobalContext.AccountId);
            ShareValue shareValue = ShareValueLogic.GetCurrentShareValueByShareId(id);

            GlobalContext.Credit += shareValue.Value;
            selectedPossession.Number--;

            if (selectedPossession.Number > 0)
            {
                PossessionLogic.UpdateNumberByShareId(selectedPossession.Number, id, GlobalContext.AccountId);           
            }
            else
            {
                PossessionLogic.DeletePossession(selectedPossession);
            }
            AccountLogic.UpdateAccountCreditByUserId(GlobalContext.Credit, GlobalContext.User.ID);
            FinanceTransactionLogic.NewTransaction(TransactionTypeEnum.Sell, 1, shareValue.ID);

            return RedirectToAction("Index");
        }


    }

}

