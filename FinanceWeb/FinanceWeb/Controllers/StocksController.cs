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


    public class StocksController : Controller
    {
        

        public IActionResult Index()
        {
            //List<Shares> shares = SharesLogic.GetShares();

            return View(SharesLogic.GetShares());
        }
    }

}