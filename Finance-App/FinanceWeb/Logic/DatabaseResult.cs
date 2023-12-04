namespace FinanceWeb.Logic
{
	public class DatabaseResult
	{
		public long LastInsertedId { get; set; }
		public List<Object[]> Data { get; set; }

        public DatabaseResult()
        {
            Data = new List<Object[]>();
        }
    }
}
