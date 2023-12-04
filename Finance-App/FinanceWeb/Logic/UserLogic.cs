using FinanceWeb.Constants;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Model;
using System;

namespace FinanceWeb.Logic
{
	public class UserLogic : DatabaseLogic
	{
		private static UserLogic _instance;
		private UserLogic() { }

		/// <summary>
		/// Get instance of UserLogic
		/// </summary>
		public static UserLogic Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new UserLogic();
				}
				return _instance;
			}
		}

		/// <summary>
		/// Insert new User record
		/// </summary>
		/// <param name="user"></param>
		/// <returns>last inserted id</returns>
		private long CreateUser(User user)
		{
			string sql = $"Insert Into {ClassContants.user} (FirstName, LastName, UserName) Value (\'{user.FirstName}\', \'{user.LastName}\', \'{user.UserName}\')";
			return GetDataReader(sql).LastInsertedId;
		}

		/// <summary>
		/// Get user by userName
		/// </summary>
		/// <param name="userName"></param>
		/// <returns></returns>
		public User GetUserByUserName(string userName)
		{
			string sql = $"SELECT * FROM {ClassContants.user} where UserName = {userName}";
			var data = GetDataReader(sql).Data[0];
			User user = new User()
			{
				ID = int.Parse(data[0].ToString()),
				FirstName = data[1].ToString(),
				LastName = data[2].ToString(),
				UserName = data[3].ToString()
			};
			return user;
		}

		/// <summary>
		/// Update user in database
		/// </summary>
		/// <param name="user"></param>
		public void UpdateUser(User user)
		{
			string sql = $"Update {ClassContants.user} Set FirstName = {user.FirstName}, LastName = {user.LastName}, UserName = {user.UserName};";
			GetDataReader(sql);
		}

		/// <summary>
		/// Delete user by Id
		/// </summary>
		/// <param name="user"></param>
		public void DeleteUser(User user)
		{
			DeleteByIds(ClassContants.user, new List<int>() { user.ID });
		}

		public void NewUser(User user)
		{
			var userId = int.Parse(CreateUser(user).ToString());
			AccountLogic.Instance.CreateAccount(userId);
		}

	}
}
