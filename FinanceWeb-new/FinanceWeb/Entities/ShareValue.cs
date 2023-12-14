using System;
using System.ComponentModel.DataAnnotations;

namespace FinanceWeb.Entities
{
    public class ShareValue
    {
        public int ID { get; set; }
        public int Value { get; set; }
        public DateTime Timestamp { get; set; }
        public int SharesID { get; set; }
        public Shares Shares { get; set; }
    }
}
