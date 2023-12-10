using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace sunuecole.models
{
    public class Supplies
    {
        [Key]
        public int IdSupplies { get; set; }
        public string NameSupplies { get; set; }
        public string? EmailSupplies { get; set; }
        public string PhoneSupplies { get; set; }
        public string? address { get; set; }
        [JsonIgnore]
        public ICollection<Orders>? Orders { get; } = new List<Orders>();
    }
}
