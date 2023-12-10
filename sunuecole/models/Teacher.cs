using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace sunuecole.models
{
    public class Teacher : BaseEntity
    {
        [Key]
        public int idTeacher { get; set; }
        public string name { get; set; }
        public char sexe { get; set; }
        public string phone { get; set; }
        public string placeOfBirth { get; set; }
        public DateTime birthDay { get; set; }
        [JsonIgnore]
        public ICollection<Lesson>? lessons { get; } = new List<Lesson>();
    }
}
