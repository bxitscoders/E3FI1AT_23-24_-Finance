using FinanceWeb.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FinanceWeb.Logic
{
    public static class SharesLogic
    {
        /// <summary>
        /// Create share in database
        /// </summary>
        /// <param name="shares"></param>
        public static void CreateShare(Shares shares)
        {
            using (var context = new FinanceDataContext())
            {
                context.Shares.Add(shares);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Get share by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Shares GetShareById(int id)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.Shares.Include(s => s.ShareValue).ToList();
                context.SaveChanges();
                return entity.FirstOrDefault();
            }
        }

        public static List<Shares> GetShares()
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.Shares.Include(s => s.ShareValue).ToList();
                context.SaveChanges();
                return entity;
            }
        }

        /// <summary>
        /// Update share in database
        /// </summary>
        /// <param name="shares"></param>
        public static void UpdateSchares(Shares shares)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.Shares.FirstOrDefault(s => s.ID == shares.ID);
                entity.Name = shares.Name;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Delete share from database
        /// </summary>
        /// <param name="shares"></param>
        public static void DeleteShares(Shares shares)
        {
            using (var context = new FinanceDataContext())
            {
                context.Shares.Remove(shares);
                context.SaveChanges();
            }
        }
    }
}
