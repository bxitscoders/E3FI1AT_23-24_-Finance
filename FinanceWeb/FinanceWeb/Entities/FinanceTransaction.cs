using FinanceWeb.Enum;
using System;

namespace FinanceWeb.Entities
{
    public class FinanceTransaction
    {
        public int ID { get; set; }
        public TransactionTypeEnum TransactionType { get; set; }
        public int Ammount { get; set; }
        public DateTime Date { get; set; }
        public int ShareValueId { get; set; }
        public ShareValue ShareValue { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
