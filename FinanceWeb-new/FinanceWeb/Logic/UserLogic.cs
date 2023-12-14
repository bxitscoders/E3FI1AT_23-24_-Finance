using FinanceWeb.Entities;
using Microsoft.AspNetCore.SignalR;

namespace FinanceWeb.Logic
{
    public static class UserLogic
    {
        public static void CreateUser(User user)
        {
            using (var context = new FinanceDataContext())
            {
                context.User.Add(user);
                context.SaveChanges();
            }
        }

        public static void UpdateUser(User user)
        {
            using (var context = new FinanceDataContext())
            {
                context.User.Update(user);
                context.SaveChanges();
            }
        }
    }
}
