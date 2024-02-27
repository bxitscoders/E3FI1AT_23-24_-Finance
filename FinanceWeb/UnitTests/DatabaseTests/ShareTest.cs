using FinanceWeb.Entities;
using FinanceWeb.Logic;
using Xunit;

namespace UnitTests.DatabaseTests
{
    public class ShareTest
    {
        [Fact]
        public void CreateShare()
        {
            var share = new Shares() { ID = 1, Name = "TestAktie" };
            SharesLogic.CreateShare(share);
        }

        [Fact]
        public void GetShareTest()
        {
            int id = 1;
            var entity = SharesLogic.GetShare(id);
            Assert.True(entity.ID == id);
        }

        [Fact]
        public void UpdateShare()
        {
            var share = new Shares() { ID = 1, Name = "TestAktie2" };
            SharesLogic.UpdateSchares(share);
            var entity = SharesLogic.GetShare(share.ID);
            Assert.Equal(share.Name, entity.Name);
        }

        [Fact]
        public void DeleteShareTest()
        {
            var share = new Shares() { ID = 1, Name = "TestAktie2" };
            SharesLogic.DeleteShares(share);
        }
    }
}
