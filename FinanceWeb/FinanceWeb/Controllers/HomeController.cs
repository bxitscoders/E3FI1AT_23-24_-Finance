using FinanceWeb.Entities;
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
            Possession selectedPossession;
            Shares share = SharesLogic.GetShareById(id);
            Account account = AccountLogic.GetAccountByUserId(GlobalContext.User.ID);
            selectedPossession = account.Possessions.FirstOrDefault(possession => possession.SharesID == id);

            if (account.Credit >= share.ShareValue.FirstOrDefault().Value)
            {
                account.Credit -= share.ShareValue.FirstOrDefault().Value;
                selectedPossession.Number++;

                AccountLogic.UpdateAccount(account);
                PossessionLogic.UpdatePossession(selectedPossession);
            }
            
            return RedirectToAction("Index");
        }

        public IActionResult SellShare(int id)
        {
            Possession selectedPossession;
            Shares share = SharesLogic.GetShareById(id);
            Account account = AccountLogic.GetAccountByUserId(GlobalContext.User.ID);
            selectedPossession = account.Possessions.FirstOrDefault(possession => possession.SharesID == id);

            account.Credit += share.ShareValue.FirstOrDefault().Value;
            selectedPossession.Number--;

            AccountLogic.UpdateAccount(account);
            if (selectedPossession.Number > 0)
                PossessionLogic.UpdatePossession(selectedPossession);
            else
                PossessionLogic.DeletePossession(selectedPossession);


            return RedirectToAction("Index");
        }
    }
}
