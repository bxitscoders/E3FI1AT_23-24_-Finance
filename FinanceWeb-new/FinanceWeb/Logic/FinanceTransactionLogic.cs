using FinanceWeb.Entities;
using System.Linq;

namespace FinanceWeb.Logic
{
    public static class FinanceTransactionLogic
    {
        public static FinanceTransaction GetFinanceTransactionById(int id)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.FinanceTransactions.ToList();
                context.SaveChanges();
                return entity.FirstOrDefault();
            }
        }
    }
}
