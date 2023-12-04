using FinanceWeb.Logic;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
	public class UserLogicTest
	{
		[Fact]
		private void CreateUserTest()
		{
			UserLogic.Instance.NewUser(new User() { FirstName = "Peter", LastName = "Lustig", UserName = "Peter4" });
		}
	}
}
