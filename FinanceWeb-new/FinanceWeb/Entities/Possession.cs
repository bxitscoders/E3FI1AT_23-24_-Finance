using System.Collections.Generic;

namespace FinanceWeb.Entities
{
    public class Possession
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public int AccountID { get; set; }
        public int SharesID { get; set; }
        public Shares Shares { get; set; }
    }
}
