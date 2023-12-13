using System.Collections.Generic;

namespace FinanceWeb.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
