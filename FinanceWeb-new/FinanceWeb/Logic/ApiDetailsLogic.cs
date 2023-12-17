using FinanceWeb.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FinanceWeb.Logic
{
    public static class ApiDetailsLogic
    {
        public static ApiDetails GetApiDetailsById(int id)
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
