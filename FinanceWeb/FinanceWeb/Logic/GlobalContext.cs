using FinanceWeb.Entities;

namespace FinanceWeb.Logic
{
    public static class GlobalContext
    {
        public static User User { get; set; }
        public static int AccountId { get; set; }
        /// <summary>
        /// Will be updated whenever a transaction happens
        /// </summary>
        public static int Credit {  get; set; }
    }
}
