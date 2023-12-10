using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace sunuecole.models
{
    public class DoClasse: BaseEntity
    {
        [Key]
        public int idDoClasse { get; set; }
        public int weekDay { get; set; }
        public int hourId { get; set; }
        public Hours? hour { get; set; }
        public int lessonId { get; set; }
        public Lesson? lesson { get; set; }
        public int roomId { get; set; }
        public Room? room { get; set; }

        [JsonIgnore]
        public ICollection<MissOrHier>? missOrHiers { get; } = new List<MissOrHier>();
    }
}
