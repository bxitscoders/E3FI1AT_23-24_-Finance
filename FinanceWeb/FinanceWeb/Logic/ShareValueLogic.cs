using FinanceWeb.Entities;
using System.Linq;

namespace FinanceWeb.Logic
{
    public static class ShareValueLogic
    {
        /// <summary>
        /// Create new share value data in the shareValues table
        /// </summary>
        /// <param name="sharesValue"></param>
        public static void CreateShareValue(ShareValue sharesValue)
        {
            using (var context = new FinanceDataContext())
            {
                context.ShareValue.Add(sharesValue);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Get the latest sharevalue for share by shareId
        /// </summary>
        /// <param name="shareId"></param>
        /// <returns></returns>
        public static ShareValue GetCurrentShareValue(int shareId)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.ShareValue.Where(shareValue => shareValue.SharesID == shareId).OrderByDescending(sv => sv.Timestamp).FirstOrDefault();
                context.SaveChanges();
                return entity;
            }
        }

        /// <summary>
        /// Update shareValue data in shareValue table
        /// </summary>
        /// <param name="shareValue"></param>
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

        /// <summary>
        /// Delete shareValue data in shareValue table
        /// </summary>
        /// <param name="shareValue"></param>
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
