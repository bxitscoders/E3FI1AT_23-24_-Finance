﻿using FinanceWeb.Entities;
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

        public IActionResult VerifyLogin(string username)
        {
            User user = UserLogic.GetUserByUsername(username);
            GlobalContext.User = user;
            if (user != null)
                return RedirectToAction("Index");
            else
                return View();
        }

        public IActionResult BuyShare(int id)
        {
            int credit = AccountLogic.GetAccountCreditByUserId(GlobalContext.User.ID);
            Possession selectedPossession = PossessionLogic.GetPossessionByShareId(id);
            ShareValue shareValue = ShareValueLogic.GetCurrentShareValueByShareId(id);

            if (credit >= shareValue.Value)
            {
                credit -= shareValue.Value;
                selectedPossession.Number++;

                AccountLogic.UpdateAccountCreditByUserId(credit, GlobalContext.User.ID);
                PossessionLogic.UpdateNumberByShareId(selectedPossession.Number, id);
                FinanceTransactionLogic.NewTransaction(TransactionTypeEnum.Buy, 1, shareValue.ID);
            }
            
            return RedirectToAction("Index");
        }

        public IActionResult SellShare(int id)
        {
            int credit = AccountLogic.GetAccountCreditByUserId(GlobalContext.User.ID);
            Possession selectedPossession = PossessionLogic.GetPossessionByShareId(id);
            ShareValue shareValue = ShareValueLogic.GetCurrentShareValueByShareId(id);

            credit += shareValue.Value;
            selectedPossession.Number--;

            if (selectedPossession.Number > 0)
            {
                PossessionLogic.UpdateNumberByShareId(selectedPossession.Number, id);           
            }
            else
            {
                PossessionLogic.DeletePossession(selectedPossession);
            }
            AccountLogic.UpdateAccountCreditByUserId(credit, GlobalContext.User.ID);
            FinanceTransactionLogic.NewTransaction(TransactionTypeEnum.Sell, 1, shareValue.ID);

            return RedirectToAction("Index");
        }


    }

}

