using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinanceWeb.Entities;
using FinanceWeb.Logic;

namespace FinanceWeb.Pages.Account.SharePage
{
    public class SharesPageModel : PageModel
    {
        private readonly FinanceWeb.Logic.FinanceDataContext _context;

        public SharesPageModel(FinanceWeb.Logic.FinanceDataContext context)
        {
            _context = context;
        }

        public IList<Shares> Shares { get;set; }

        public async Task OnGetAsync()
        {
            Shares = await _context.Shares.ToListAsync();
        }
    }
}
