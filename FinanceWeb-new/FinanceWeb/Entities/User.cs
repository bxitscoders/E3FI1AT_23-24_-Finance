using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinanceWeb.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public virtual List<Account> Accounts { get; set; }
    }
}
