using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace sunuecole.models
{
    public class Hours: BaseEntity
    {
        [Key]
        public int idHours { get; set; }
        public TimeOnly heure { get; set; }
        public string description { get; set; }
        [JsonIgnore]
        public ICollection<DoClasse>? doClasse { get; } = new List<DoClasse>();

    }
}
