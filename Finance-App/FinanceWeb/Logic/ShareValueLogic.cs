using FinanceWeb.Constants;
using Model;

namespace FinanceWeb.Logic
{
	public class ShareValueLogic : DatabaseLogic
	{
		/// <summary>
		/// Insert new sharesValue record
		/// </summary>
		/// <param name="sharesValue"></param>
		/// <returns>last inserted id</returns>
		public long CreateShareValue(Sharevalue sharesValue)
		{
			string sql = $"Insert Into {ClassContants.sharesValue} (Value, TimeStamp, SharesFK) Values ({sharesValue.Value}, {sharesValue.TimeStamp}, {sharesValue.SharesFK});";
			return GetDataReader(sql).LastInsertedId;
		}
	}
}
