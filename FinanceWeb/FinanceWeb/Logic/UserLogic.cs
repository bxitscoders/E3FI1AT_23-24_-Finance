using FinanceWeb.Entities;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace FinanceWeb.Logic
{
    public static class UserLogic
    {
        /// <summary>
        /// Create user data in the user table
        /// </summary>
        /// <param name="user"></param>
        public static int CreateUser(User user)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.User.Add(user);
                context.SaveChanges();
                return entity.Entity.ID;
            }
        }

        /// <summary>
        /// Get User by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static User GetUser(int id)
        {
            using (var context = new FinanceDataContext())
            {
                List<User> users = context.User.Where(u => u.ID == id).Include(u => u.Accounts).ToList();
                return users.FirstOrDefault();
            }
        }

        /// <summary>
        /// Get user by userName
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static User GetUser(string username)
        {
            using (var context = new FinanceDataContext())
            {
                List<User> users = context.User.Where(u => u.UserName== username).ToList();
                GlobalContext.User = users.FirstOrDefault();
                return users.FirstOrDefault();
            }
        }

        /// <summary>
        /// Update a user in database
        /// </summary>
        /// <param name="user"></param>
        public static void UpdateUser(User user)
        {
            using (var context = new FinanceDataContext())
            {
                var entity = context.User.FirstOrDefault(u => u.ID == user.ID);
                if (entity != null)
                {
                    entity.FirstName = user.FirstName;
                    entity.LastName = user.LastName;
                    entity.UserName = user.UserName;
                }
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Delete a user in database
        /// </summary>
        /// <param name="user"></param>
        public static void DeleteUser(User user)
        {
            using (var context = new FinanceDataContext())
            {
                context.User.Remove(user);
                context.SaveChanges();
            }
        }
    }
}
