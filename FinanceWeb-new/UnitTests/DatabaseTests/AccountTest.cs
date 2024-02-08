using FinanceWeb.Entities;
using FinanceWeb.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.DatabaseTests
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void CreateAccountTest()
        {
            Account account = new Account() { ID = 1, Credit = 10000, UserID = 1 };
            AccountLogic.CreateAccount(account);
        }

        [TestMethod]
        public void GetAccountTest()
        {
            int id = 1;
            var entity = AccountLogic.GetAccountByUserId(id);
            Assert.IsTrue(entity.ID == id);
        }

        [TestMethod]
        public void UpdateAccountTest()
        {
            Account account = new Account() { ID = 1, Credit = 20000, UserID = 1 };
            AccountLogic.UpdateAccount(account);
            var entity =AccountLogic.GetAccountByUserId(account.ID);
            Assert.IsTrue(account.Credit == entity.Credit);
        }

        [TestMethod]
        public void DeleteAccountTest()
        {
            Account account = new Account() { ID = 1, Credit = 20000, UserID = 1 };
            AccountLogic.DeleteAccount(account);
            var entity = AccountLogic.GetAccountByUserId(account.ID);
            Assert.IsNull(entity);
        }
    }
}
