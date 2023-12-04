using FinanceWeb.Logic;
using Model;
using FinanceWeb.Constants;
using Xunit.Sdk;

namespace UnitTest
{
	public class DatabaseLogicTest : DatabaseLogic
	{
		[Fact]
		private void GetUserTest()
		{
			List<User> userList = new List<User>();
			var data = GetById(ClassContants.user, 2);

			foreach (var item in data)
			{
				User user = new User();
				user.ID = Int32.Parse(item[0].ToString());
				user.FirstName = item[1].ToString();
				user.LastName = item[2].ToString();
				user.UserName = item[3].ToString();
				userList.Add(user);
			}

			Assert.NotEmpty(userList);
		}

		[Fact]
		private void GetByIdTest()
		{
			int id = 1;
			var data = GetById(ClassContants.user, id);

			Assert.NotEmpty(data);
		}

		[Fact]
		private void GetByIdsTest()
		{
			List<int> ids = new List<int>() {0,1};
			var data = GetByIds(ClassContants.user, ids);

			Assert.NotEmpty(data);
		}

		[Fact]
		private void DeleteByIdsTest()
		{
			List<int> ids = new List<int>() { 1, 2 };
			DeleteByIds(ClassContants.user, ids);

		}
	}
}