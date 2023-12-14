using FinanceWeb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;

namespace FinanceWeb.Logic
{
    public class DatabaseLogic
    {
        public void Connection()
        {
            using (var context = new FinanceDataContext())
            {
                var user = context.User.Include(u => u.Accounts);
                context.SaveChanges();
            }
        }
    }
}
