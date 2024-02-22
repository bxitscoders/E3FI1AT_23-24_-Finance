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
            var account = AccountLogic.GetAccountByUserId(GlobalContext.User.ID);
            ShareValue shareValue = ShareValueLogic.GetCurrentShareValueByShareId(id);
            if (GlobalContext.Credit >= shareValue.Value)
            {
                Possession possession = PossessionLogic.GetPossessionByShareId(id) ?? PossessionLogic.CreatePossession(new Possession() { AccountID = account.ID, Number = 0, SharesID = id });

                GlobalContext.Credit -= shareValue.Value;
                possession.Number++;

                AccountLogic.UpdateAccountCreditByUserId(GlobalContext.Credit, GlobalContext.User.ID);
                PossessionLogic.UpdateNumberByShareId(possession.Number, id);
                FinanceTransactionLogic.NewTransaction(TransactionTypeEnum.Buy, 1, shareValue.ID);
            }
            return RedirectToAction("Index");
        }
    }

}