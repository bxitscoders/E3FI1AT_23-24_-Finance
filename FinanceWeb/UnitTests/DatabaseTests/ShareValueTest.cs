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
    public class ShareValueTest
    {
        private static DateTime _dateTime = DateTime.Now;
        [Fact]
        public void CreateShareValueTest()
        {
            ShareValue shareValue = new ShareValue() { ID = 1, Value = 50, Timestamp = _dateTime };
            ShareValueLogic.CreateShareValue(shareValue);
        }

        [Fact]
        public void GetShareValueTest()
        {
            int shareId = 1;
            var entity = ShareValueLogic.GetCurrentShareValue(shareId);
            Assert.True(entity.ID == shareId);
        }

        [Fact]
        public void UpdateShareValueTest()
        {
            ShareValue shareValue = new ShareValue() { ID = 1, Value = 200, Timestamp = _dateTime };
            ShareValueLogic.UpdateShareValue(shareValue);
        }

        [Fact]
        public void DeleteShareValueTest()
        {
            ShareValue shareValue = new ShareValue() { ID = 1, Value = 200, Timestamp = _dateTime };
            ShareValueLogic.DeleteShareValue(shareValue);
        }
    }
}
