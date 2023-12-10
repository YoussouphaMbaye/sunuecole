using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace sunuecole.models
{
    public class Tutor : BaseEntity
    {
        [Key]
        public int IdTutor { get; set; }
        public string NameTutor { get; set; }
        public string PhoneTutor { get; set; }
        public string? address { get; set; }
        public char sexe { get; set; }
        public string? email { get; set; }
        public DateOnly? BirthDay { get; set; }
        [JsonIgnore]
        public ICollection<Students>? students { get; } = new List<Students>();
    }
}
