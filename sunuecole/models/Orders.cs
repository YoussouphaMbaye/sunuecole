using System.ComponentModel.DataAnnotations;

namespace sunuecole.models
{
    public class Orders
    {
        [Key]
        public int IdOrders { get; set; }
        public string productName { get; set; }
        public double productQuantity { get; set; }
        public double unitPrice { get; set; }
        public double total { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public int agentID { get; set; }
        public Agents? agents { get; set; }
        public int suppliesID { get; set; }
        public Supplies? supplie { get; set; }

    }
}
