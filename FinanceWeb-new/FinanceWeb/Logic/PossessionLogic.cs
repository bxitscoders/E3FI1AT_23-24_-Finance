using FinanceWeb.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace FinanceWeb.Logic
{
    public static class PossessionLogic
    {
        public static void CreatePossession(Possession possession)
        {
            using (var context = new FinanceDataContext())
            {
                context.Possession.Add(possession);
                context.SaveChanges();
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

        public static void UpdatePossession(Possession possession)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.Possession.FirstOrDefault(s => s.ID == possession.ID);
                entity.Number = possession.Number;
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
    }
}
