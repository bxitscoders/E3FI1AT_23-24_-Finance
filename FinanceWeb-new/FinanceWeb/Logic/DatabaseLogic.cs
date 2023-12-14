using FinanceWeb.Entities;
using System.Linq;

namespace FinanceWeb.Logic
{
    public class DatabaseLogic
    {
        public void Connection()
        {
            using (var context = new FinanceDataContext())
            {
                context.User.Add(new User { UserId = 1, FirstName = "ralf" , LastName = "", UserName= "ralf"});
                context.SaveChanges();
            }
        }
    }
}
