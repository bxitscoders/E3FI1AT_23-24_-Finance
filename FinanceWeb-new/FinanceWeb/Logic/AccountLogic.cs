using FinanceWeb.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FinanceWeb.Logic
{
    public static class AccountLogic
    {
        /// <summary>
        /// Create an account in Database
        /// </summary>
        /// <param name="account"></param>
        public static void CreateAccount(Account account)
        {
            using (var context = new FinanceDataContext())
            {
                context.Account.Add(account);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Get account by userId
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static Account GetAccountByUserId(int id)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.Account.Where(a => a.UserID == id).Include(a => a.Possessions).ThenInclude(p => p.Shares).ThenInclude(s => s.ShareValue).ToList();
                return entity.FirstOrDefault();
            }
        }

        /// <summary>
        /// Update account
        /// </summary>
        /// <param name="account"></param>
        public static void UpdateAccount(Account account)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.Account.FirstOrDefault(a => a.ID == account.ID);
                if (entity != null)
                {
                    entity.Credit = account.Credit;
                }
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Remove account from database
        /// </summary>
        /// <param name="account"></param>
        public static void DeleteAccount(Account account)
        {
            using (var context = new FinanceDataContext())
            {
                context.Account.Remove(account);
                context.SaveChanges();
            }
        }
    }
}
