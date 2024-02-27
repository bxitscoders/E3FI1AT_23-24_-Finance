using FinanceWeb.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FinanceWeb.Logic
{
    public static class AccountLogic
    {
        /// <summary>
        /// Create an account in 
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
        public static Account GetAccount(int userId)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.Account.Where(a => a.UserID == userId).Include(a => a.Possessions).ThenInclude(p => p.Shares).ThenInclude(s => s.ShareValue).ToList();
                return entity.FirstOrDefault();
            }
        }

        /// <summary>
        /// Get credit from account by userId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static int GetAccountCredit(int userId)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.Account.Where(a => a.UserID == userId).ToList();
                return entity.FirstOrDefault().Credit;
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
        /// Set new Credit into database by userId
        /// </summary>
        /// <param name="newCredit"></param>
        /// <param name="userId"></param>
        public static void UpdateAccountCreditByUserId(int newCredit, int userId)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.Account.FirstOrDefault(a => a.UserID == userId);
                if (entity != null)
                {
                    entity.Credit =newCredit;
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
