using Model;

namespace FinanceWeb.Interface
{
	public interface IAppContext
	{
		/// <summary>
		/// Login Username
		/// </summary>
		string UserName { get; }

		/// <summary>
		/// Last login date
		/// </summary>
		DateTime? LastLogin { get; }

		/// <summary>
		/// Id of Account
		/// </summary>
		int AccountId { get; }

		/// <summary>
		/// App language
		/// </summary>
		string Language { get; }
	}
}
