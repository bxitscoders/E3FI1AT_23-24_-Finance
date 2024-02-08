using FinanceWeb.Entities;
using System.Linq;

namespace FinanceWeb.Logic
{
    public static class ShareValueLogic
    {
        public static void CreateShareValue(ShareValue sharesValue)
        {
            using (var context = new FinanceDataContext())
            {
                context.ShareValue.Add(sharesValue);
                context.SaveChanges();
            }
        }

        public static ShareValue GetShareValueById(int id)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.ShareValue.ToList();
                context.SaveChanges();
                return entity.FirstOrDefault();
            }
        }

        public static void UpdateShareValue(ShareValue shareValue)
        {
            using (var context = new FinanceDataContext())
            {
                var entitys = context.ShareValue.FirstOrDefault(sv => sv.ID == shareValue.ID);
                entitys.Value = shareValue.Value;
                entitys.Timestamp = shareValue.Timestamp;
                context.SaveChanges();
            }
        }

        public static void DeleteShareValue(ShareValue shareValue)
        {
            using (var context = new FinanceDataContext())
            {
                context.Remove(shareValue);
                context.SaveChanges();
            }
        }
    }
}
