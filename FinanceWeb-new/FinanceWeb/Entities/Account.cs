using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;

namespace FinanceWeb.Entities
{
    public class Account
    {
        public int ID { get; set; }
        public int Credit { get; set; }
        public int UserID { get; set; }
        public virtual ICollection<Possession> Possessions { get; set; }
    }
}
