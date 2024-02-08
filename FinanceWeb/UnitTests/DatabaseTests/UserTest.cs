using FinanceWeb.Entities;
using FinanceWeb.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests.DatabaseTests
{
    public class UserTest
    {
        [Fact]
        public void CreateUserTest()
        {
            User user = new User() { ID = 15, FirstName = "Karl", LastName = "das Lama", UserName = "KarlDasLama" };
            UserLogic.CreateUser(user);
        }

        [Fact]
        public void GetUserTest()
        {
            int id = 15;
            User user = UserLogic.GetUserById(id);
            Assert.True(id == user.ID);
        }

        [Fact]
        public void UpdateUserTest()
        {
            User user = new User() { ID = 15, FirstName = "Karl2", LastName = "das Lama2", UserName = "KarlDasLama2" };
            UserLogic.UpdateUser(user);
        }

        [Fact]
        public void DeleteUserTest()
        {
            User user = new User() { ID = 15, FirstName = "Karl2", LastName = "das Lama2", UserName = "KarlDasLama2" };
            UserLogic.DeleteUser(user);
        }
    }
}
