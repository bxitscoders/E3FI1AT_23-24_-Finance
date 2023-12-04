using FinanceWeb.Constants;
using Model;

namespace FinanceWeb.Logic
{
	public class ShareLogic :DatabaseLogic
	{

		/// <summary>
		/// Insert new shares record
		/// </summary>
		/// <param name="shares"></param>
		/// <returns>last inserted id</returns>
		public long CreateShares(Shares shares)
		{
			string sql = $"Insert Into {ClassContants.shares} (Name) Values ({shares.Name})";
			return GetDataReader(sql).LastInsertedId;
		}
	}
}
