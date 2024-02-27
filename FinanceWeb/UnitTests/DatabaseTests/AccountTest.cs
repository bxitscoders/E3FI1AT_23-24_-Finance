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
    public class AccountTest
    {
        [Fact]
        public void CreateAccountTest()
        {
            Account account = new Account() { ID = 1, Credit = 10000, UserID = 1 };
            AccountLogic.CreateAccount(account);
        }

        [Fact]
        public void GetAccountTest()
        {
            int id = 1;
            var entity = AccountLogic.GetAccount(id);
            Assert.True(entity.ID == id);
        }

        [Fact]
        public void UpdateAccountTest()
        {
            Account account = new Account() { ID = 1, Credit = 20000, UserID = 1 };
            AccountLogic.UpdateAccount(account);
            var entity = AccountLogic.GetAccount(account.ID);
            Assert.True(account.Credit == entity.Credit);
        }

        [Fact]
        public void DeleteAccountTest()
        {
            Account account = new Account() { ID = 1, Credit = 20000, UserID = 1 };
            AccountLogic.DeleteAccount(account);
            var entity = AccountLogic.GetAccount(account.ID);
            Assert.Null(entity);
        }
    }
}
