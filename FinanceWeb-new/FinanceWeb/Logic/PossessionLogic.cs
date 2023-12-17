using FinanceWeb.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FinanceWeb.Logic
{
    public class PossessionLogic
    {
        public static void CreatePossession(Possession possession)
        {
            using (var context = new FinanceDataContext())
            {
                context.Possession.Add(possession);
                context.SaveChanges();
            }
        }

        public static Possession GetPossessionById(int id)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.Possession.Include(s => s.Shares).ToList();
                context.SaveChanges();
                return entity.FirstOrDefault();
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
