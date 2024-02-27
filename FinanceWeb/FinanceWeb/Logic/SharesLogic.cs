using FinanceWeb.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FinanceWeb.Logic
{
    public static class SharesLogic
    {
        /// <summary>
        /// Create share data in the shares table
        /// </summary>
        /// <param name="shares"></param>
        /// <returns>Share Id</returns>
        public static int CreateShare(Shares shares)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.Shares.Add(shares);
                context.SaveChanges();
                return entity.Entity.ID;
            }
        }

        /// <summary>
        /// Get share by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Shares GetShare(int id)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.Shares.Include(s => s.ShareValue).Where(s => s.ID == id).ToList();
                context.SaveChanges();
                return entity.FirstOrDefault();
            }
        }

        /// <summary>
        /// Get share by shareName
        /// </summary>
        /// <param name="shareName"></param>
        /// <returns></returns>
        public static int GetShareId(string shareName)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.Shares.Where(s => s.Name == shareName).ToList();
                context.SaveChanges();
                return entity.FirstOrDefault().ID;
            }
        }

        /// <summary>
        /// Checks if share excists in database by name
        /// </summary>
        /// <param name="shareName"></param>
        /// <returns>true when share excists and false if not</returns>
        public static bool ShareExists(string shareName)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.Shares.Where(s => s.Name == shareName).ToList();
                context.SaveChanges();
                return entity.Count > 0;
            }
        }

        /// <summary>
        /// Get all shares from database
        /// </summary>
        /// <returns></returns>
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
