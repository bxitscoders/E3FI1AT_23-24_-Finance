using FinanceWeb.Entities;
using FinanceWeb.Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace FinanceWeb.Pages.Account
{
    public class HomeWindowModel : PageModel
    {
        [BindProperty]
        public Entities.Account Account { get; set; }
        public void OnGet()
        {
            Account = AccountLogic.GetAccountByUserId(14);
          }
    }
}
