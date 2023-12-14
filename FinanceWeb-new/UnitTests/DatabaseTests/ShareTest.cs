using FinanceWeb.Entities;
using FinanceWeb.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.DatabaseTests
{
    [TestClass]
    public class ShareTest
    {
        [TestMethod]
        public void CreateShare()
        {
            var share = new Shares() { ID = 1, Name = "TestAktie" };
            SharesLogic.CreateShare(share);
        }

        [TestMethod]
        public void GetShareTest()
        {
            int id = 1;
            var entity = SharesLogic.GetShareById(id);
            Assert.IsTrue(entity.ID == id);
        }

        [TestMethod]
        public void UpdateShare()
        {
            var share =  new Shares() { ID = 1, Name = "TestAktie2"};
            SharesLogic.UpdateSchares(share);
            var entity = SharesLogic.GetShareById(share.ID);
            Assert.AreEqual(share.Name, entity.Name);
        }

        [TestMethod]
        public void DeleteShareTest()
        {
            var share = new Shares() { ID = 1, Name = "TestAktie2" };
            SharesLogic.DeleteShares(share);
        }
    }
}
