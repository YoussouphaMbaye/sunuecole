using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace sunuecole.models
{
    public class SchoolYear:BaseEntity
    {

        [Key]
        public int IdSchoolYear { get; set; }

        public string year { get; set; }
        public string description { get; set; }
        [JsonIgnore]
        public ICollection<RegisterClasse>? rClasse { get; } = new List<RegisterClasse>();
        [JsonIgnore]
        public ICollection<Evaluation>? evaluations { get; } = new List<Evaluation>();
        [JsonIgnore]
        public ICollection<InfSubscribe>? infSubscribes { get; } = new List<InfSubscribe>();
    }
}
