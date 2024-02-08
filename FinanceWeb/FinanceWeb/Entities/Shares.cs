using System.Collections.Generic;

namespace FinanceWeb.Entities
{
    public class Shares
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<ShareValue> ShareValue { get; set; }
    }
}
