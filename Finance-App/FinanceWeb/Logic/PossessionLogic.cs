using FinanceWeb.Constants;
using Model;

namespace FinanceWeb.Logic
{
	public class PossessionLogic : DatabaseLogic
	{
		/// <summary>
		/// Insert new Besitz record
		/// </summary>
		/// <param name="number"></param>
		/// <param name="shares"></param>
		/// <returns>last inserted id</returns>
		public long CreatePossession(int number, Shares shares)
		{
			string sql = $"Inster Into {ClassContants.possession} (Number, AccountFK, SharesFK) Values ({number}, {1}, {shares.ID})";
			return GetDataReader(sql).LastInsertedId;
		}
	}
}