using FinanceWeb.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace FinanceWeb.Logic
{
    public static class PossessionLogic
    {
        public static Possession CreatePossession(Possession possession)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.Possession.Add(possession);
                context.SaveChanges();
                return entity.Entity;
            }
        }

        public static List<Possession> GetPossessionByAccountId(int id)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.Possession.Where(possession => possession.AccountID == id).Include(s => s.Shares).ThenInclude(s => s.ShareValue).ToList();
                context.SaveChanges();
                return entity;
            }
        }

        public static Possession GetPossessionByShareId(int shareId)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.Possession.Where(possession => possession.SharesID == shareId).Include(s => s.Shares).ThenInclude(s => s.ShareValue).OrderByDescending(e => e.Shares.ShareValue.First().Timestamp).ToList();
             
                return entity.FirstOrDefault();
            }
        }

        public static void UpdateNumberByShareId(int newNumber ,int shareId)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.Possession.FirstOrDefault(p => p.SharesID == shareId);
                entity.Number = newNumber;
                context.SaveChanges();
            }
        }

        public static void DeletePossession(Possession possession)
        {
            using (var context = new FinanceDataContext())
            {
                context.Possession.Remove(possession);
                context.SaveChanges();
            }
        }

        public static void Sell()
        {

        }
    }
}
