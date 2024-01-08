using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinanceWeb.Entities;
using FinanceWeb.Logic;

namespace FinanceWeb.Pages.Account
{
    public class EditModel : PageModel
    {
        private readonly FinanceWeb.Logic.FinanceDataContext _context;

        public EditModel(FinanceWeb.Logic.FinanceDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Possession Possession { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Possession = await _context.Possession.FirstOrDefaultAsync(m => m.ID == id);

            if (Possession == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Possession).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PossessionExists(Possession.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PossessionExists(int id)
        {
            return _context.Possession.Any(e => e.ID == id);
        }
    }
}
