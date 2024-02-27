using FinanceWeb.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace FinanceWeb.Logic
{
    public static class PossessionLogic
    {
        /// <summary>
        /// Create new possession data in the possession table
        /// </summary>
        /// <param name="possession"></param>
        /// <returns></returns>
        public static Possession CreatePossession(Possession possession)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.Possession.Add(possession);
                context.SaveChanges();
                return entity.Entity;
            }
        }

        /// <summary>
        /// Get possession by accountId
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public static List<Possession> GetPossession(int accountId)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.Possession.Where(possession => possession.AccountID == accountId).Include(s => s.Shares).ThenInclude(s => s.ShareValue).ToList();
                context.SaveChanges();
                return entity;
            }
        }

        /// <summary>
        /// Get possession by shareId
        /// </summary>
        /// <param name="shareId"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public static Possession GetPossession(int shareId, int accountId)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.Possession.Where(possession => possession.SharesID == shareId && possession.AccountID == accountId).Include(s => s.Shares).ThenInclude(s => s.ShareValue).OrderByDescending(e => e.Shares.ShareValue.First().Timestamp).ToList();
             
                return entity.FirstOrDefault();
            }
        }

        /// <summary>
        /// Update amount in database for one possession
        /// </summary>
        /// <param name="newNumber"></param>
        /// <param name="shareId"></param>
        /// <param name="accountId"></param>
        public static void UpdateAmount(int newNumber ,int shareId, int accountId)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.Possession.FirstOrDefault(p => p.SharesID == shareId && p.AccountID == accountId);
                entity.Number = newNumber;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Delete possession in database
        /// </summary>
        /// <param name="possession"></param>
        public static void DeletePossession(Possession possession)
        {
            using (var context = new FinanceDataContext())
            {
                context.Possession.Remove(possession);
                context.SaveChanges();
            }
        }
    }
}
