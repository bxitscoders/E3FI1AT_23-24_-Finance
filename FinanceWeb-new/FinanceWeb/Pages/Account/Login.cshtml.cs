using FinanceWeb.Entities;
using FinanceWeb.Logic;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FinanceWeb.Pages.Account
{

    public class LoginModel : PageModel
    {

        private readonly ILogger<LoginModel> _logger;

        [BindProperty]
        public InputModel Input { get; set; }

        public LoginModel(ILogger<LoginModel> logger)
        {
            _logger = logger;
        }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Required]
            public User User { get; set; }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (UserLogic.GetUserByUsername(Input.User.UserName) != null)
            {
                return RedirectToPage("./HomeWindow");
            }
            else
            {
                return Page();
            }        
        }
        public void LogInClick()
        {
            if (UserLogic.GetUserByUsername(Input.User.UserName) != null)
            {
                RedirectToPage("./HomeWindow");
            }
        }
    }
}
