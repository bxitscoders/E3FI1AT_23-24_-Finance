using FinanceWeb.Interface;

namespace FinanceWeb.Environment
{
	public class Context : IAppContext
	{
		private static Context _context;
		public string UserName { get; set; }
		public DateTime? LastLogin { get; set; }
		public int AccountId { get; set; }
		public string Language { get; set; }

		private Context()
		{
			UserName = string.Empty;
			LastLogin = DateTime.Now;
			Language = string.Empty;
			AccountId = 0;
		}
		public static Context Instance
		{
			get
			{
				if (_context == null)
				{
					_context = new Context();
				}
				return _context;
			}
		}
	}
}
