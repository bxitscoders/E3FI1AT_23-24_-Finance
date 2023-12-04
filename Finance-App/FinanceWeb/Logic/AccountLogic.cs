using FinanceWeb.Constants;

namespace FinanceWeb.Logic
{
	public class AccountLogic : DatabaseLogic
	{
		private static AccountLogic _instance;
		private AccountLogic() { }
		public static AccountLogic Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new AccountLogic();
				}
				return _instance;
			}
		}
		/// <summary>
		/// Insert new Account record
		/// </summary>
		/// <param name="user"></param>
		/// <returns>last inserted id</returns>
		public long CreateAccount(int userId)
		{
			string sql = $"Insert Into {ClassContants.konto} (Credit, UserFK) Values ({KontoDefault.Credit}, {userId})";
			return GetDataReader(sql).LastInsertedId;
		}

		/// <summary>
		/// Update Account in database
		/// </summary>
		/// <param name="newCredit"></param>
		public void UpdateKonto(int newCredit)
		{
			string sql = $"Update {ClassContants.konto} Set Credit = {newCredit}";
			GetDataReader(sql);
		}
	}
}
