using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinanceWeb.Logic;
using FinanceWeb.Entities;

namespace UnitTests
{
    [TestClass]
    public class CRUDTests
    {
        [TestMethod]
        public void CreateUserTest()
        {
            User user = new User() { FirstName = "Karl", LastName = "das Lama", UserName = "KarlDasLama" };
            UserLogic.CreateUser(user);
        }

        [TestMethod]
        public void UpdateUserTest()
        {
            User user = new User() { FirstName = "Karl", LastName = "", UserName = "KarlDasLama" };
            UserLogic.UpdateUser(user);
        }
    }
}
