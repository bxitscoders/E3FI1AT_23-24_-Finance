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
    public class ShareValueTest
    {
        private static DateTime _dateTime = DateTime.Now;
        [TestMethod]
        public void CreateShareValueTest()
        {
            ShareValue shareValue = new ShareValue() { ID = 1, Value = 50, Timestamp = _dateTime};
            ShareValueLogic.CreateShareValue(shareValue);
        }

        [TestMethod]
        public void GetShareValueTest()
        {
            int id = 1;
            var entity = ShareValueLogic.GetShareValueById(id);
            Assert.IsTrue(entity.ID == id);
        }

        [TestMethod]
        public void UpdateShareValueTest()
        {
            ShareValue shareValue = new ShareValue() { ID= 1, Value = 200, Timestamp = _dateTime};
            ShareValueLogic.UpdateShareValue(shareValue);
        }

        [TestMethod]
        public void DeleteShareValueTest()
        {
            ShareValue shareValue = new ShareValue() { ID = 1, Value = 200, Timestamp = _dateTime };
            ShareValueLogic.DeleteShareValue(shareValue);
        }
    }
}
