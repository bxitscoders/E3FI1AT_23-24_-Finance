using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinanceWeb.Logic;
using FinanceWeb.Entities;

namespace UnitTests.DatabaseTests
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void CreateUserTest()
        {
            User user = new User() { ID = 15, FirstName = "Karl", LastName = "das Lama", UserName = "KarlDasLama" };
            UserLogic.CreateUser(user);
        }

        [TestMethod]
        public void GetUserTest()
        {
            int id = 15;
            User user = UserLogic.GetUserById(id);
            Assert.IsTrue(id == user.ID);
        }

        [TestMethod]
        public void UpdateUserTest()
        {
            User user = new User() { ID = 15, FirstName = "Karl2", LastName = "das Lama2", UserName = "KarlDasLama2" };
            UserLogic.UpdateUser(user);
        }

        [TestMethod]
        public void DeleteUserTest()
        {
            User user = new User() { ID = 15, FirstName = "Karl2", LastName = "das Lama2", UserName = "KarlDasLama2" };
            UserLogic.DeleteUser(user);
        }
    }
}
