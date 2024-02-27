using FinanceWeb.Entities;
using FinanceWeb.Enum;
using FinanceWeb.Logic;
using FinanceWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;



namespace FinanceWeb.Controllers
{


    public class StocksController : Controller
    {


        public IActionResult Index()
        {
            List<Shares> shares = SharesLogic.GetShares();
            ViewBag.Credit = GlobalContext.Credit;
            return View(shares);
        }

        public IActionResult BuyShare(int id)
        {
            ShareValue shareValue = ShareValueLogic.GetCurrentShareValue(id);
            if (GlobalContext.Credit >= shareValue.Value)
            {
                Possession possession = PossessionLogic.GetPossession(id, GlobalContext.AccountId) ?? PossessionLogic.CreatePossession(new Possession() { AccountID = GlobalContext.AccountId, Number = 0, SharesID = id });

                GlobalContext.Credit -= shareValue.Value;
                possession.Number++;

                AccountLogic.UpdateAccountCreditByUserId(GlobalContext.Credit, GlobalContext.User.ID);
                PossessionLogic.UpdateAmount(possession.Number, id, GlobalContext.AccountId);
                FinanceTransactionLogic.NewTransaction(TransactionTypeEnum.Buy, 1, shareValue.ID);
            }
            return RedirectToAction("Index");
        }

        public IActionResult LoadStocks()
        {
            ApiLogic.LoadAPIStocks();
            return RedirectToAction("Index");
        }

    }
}