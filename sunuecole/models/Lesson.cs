using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace sunuecole.models
{
    public class Lesson : BaseEntity
    {
        [Key]
        public int idLesson { get; set; }
        public string name { get; set; }
        public int coefficient { get; set; }
        public string description { get; set; }
        public int idTeacher { get; set; }
        public Teacher? teacher { get; set; }
        public int classeId { get; set; }
        public Classe? classe { get; set; }
        [JsonIgnore]
        public ICollection<DoClasse>? doClasse { get; } = new List<DoClasse>();

        [JsonIgnore]
        public ICollection<Evaluation>? evaluations { get; } = new List<Evaluation>();

    }
}
