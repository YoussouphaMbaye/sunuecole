using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace sunuecole.models
{
    public class InfSubscribe:BaseEntity
    {
        [Key]
        public int IdInfSubscribe { get; set; }
        public string montant { get; set; }
        public string description { get; set; }
        public int classeID { get; set; }
        public int schoolYearID { get; set; }
        public SchoolYear? schoolYear { get; set; }
        public Classe? classe { get; set; }
        [JsonIgnore]
        public ICollection<PaidSubscribe>? paidSubscribes { get; } = new List<PaidSubscribe>();

    }
}
