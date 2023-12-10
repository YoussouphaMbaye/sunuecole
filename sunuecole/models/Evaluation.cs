using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace sunuecole.models
{
    public class Evaluation : BaseEntity
    {
        [Key]
        public int idEvaluation { get; set; }
        public string name { get; set; }
        public string staus { get; set; }
        public string description { get; set; }
        public string evaluationType { get; set; }
        public int semestre { get; set; }
        public DateTime evaluationDate { get; set; }
        public int lessonId { get; set; }
        public Lesson? lesson { get; set; }
        public int schoolYearID { get; set; }
        public SchoolYear? schoolYear { get; set; }
        [JsonIgnore]
        public ICollection<Note>? notes { get; } = new List<Note>();
    }
}
