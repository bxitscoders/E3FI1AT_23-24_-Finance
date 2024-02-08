using FinanceWeb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;

namespace FinanceWeb.Logic
{
    public static class DatabaseLogic
    {
        public static FinanceDataContext GetContext()
        {
            using (var context = new FinanceDataContext())
            {
                return context;
            }
        }
    }
}
