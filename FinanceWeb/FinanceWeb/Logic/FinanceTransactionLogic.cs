using FinanceWeb.Entities;
using FinanceWeb.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinanceWeb.Logic
{
    public static class FinanceTransactionLogic
    {
        /// <summary>
        /// Create a new financeTransaction in database
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="ammount"></param>
        /// <param name="shareValueId"></param>
        public static void NewTransaction(TransactionTypeEnum transactionType, int ammount, int shareValueId)
        {
            var transaction = new FinanceTransaction() {UserId = GlobalContext.User.ID , Date= DateTime.Now, TransactionType = transactionType, Ammount = ammount, ShareValueId = shareValueId };
            using (var context = new FinanceDataContext())
            {
                var entity = context.FinanceTransaction.Add(transaction);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Get all transactions by userId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static List<FinanceTransaction> GetFinanceTransactions(int userId)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.FinanceTransaction.Where(ft => ft.UserId == userId).Include(f => f.ShareValue).ToList();
                return entity;
            }
        }
    }
}
