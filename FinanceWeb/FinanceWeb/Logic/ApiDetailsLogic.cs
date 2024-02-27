using FinanceWeb.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FinanceWeb.Logic
{
    public static class ApiDetailsLogic
    {
        /// <summary>
        /// Get api details
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static ApiDetails GetApiDetails(int id)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.ApiDetails.ToList();
                context.SaveChanges();
                return entity.FirstOrDefault();
            }
        }
    }
}
