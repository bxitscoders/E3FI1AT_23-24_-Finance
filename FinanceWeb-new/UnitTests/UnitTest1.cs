using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinanceWeb.Logic;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DatabaseLogic databaseLogic = new DatabaseLogic();
            databaseLogic.Connection();
        }
    }
}
