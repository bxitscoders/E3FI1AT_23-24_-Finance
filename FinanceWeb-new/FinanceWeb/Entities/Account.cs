using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;

namespace FinanceWeb.Entities
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        public int Credit { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
