using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace sunuecole.models
{
    public class Classe:BaseEntity
    {
        [Key]
        public int IdClasse{ get; set; }

        public string NameClasse{ get; set; }
        public int niveau { get; set; }
        public string description { get; set; }
        [JsonIgnore]
        public ICollection<RegisterClasse>? rClasse { get; } = new List<RegisterClasse>();
        [JsonIgnore]
        public ICollection<Lesson>? lessons { get; } = new List<Lesson>();
        [JsonIgnore]
        public ICollection<InfSubscribe>? infSubscribes { get; } = new List<InfSubscribe>();


    }
}
