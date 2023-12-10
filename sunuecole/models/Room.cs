using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace sunuecole.models
{
    public class Room:BaseEntity
    {
        [Key]
        public int idRoom { get; set; }
        public string name { get; set; }
        public int placeCount { get; set; }
        public string description { get; set; }
        [JsonIgnore]
        public ICollection<DoClasse>? doClasse { get; } = new List<DoClasse>();
    }
}
