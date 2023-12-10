using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace sunuecole.models
{
    public class Students:BaseEntity
    {
        [Key]
        public int IdStudents { get; set; }
        public string NameStudents{ get; set; }
        public string? email { get; set; }
        public string PlaceOfBirth { get; set; }
        public string code { get; set; }
        public char sexe { get; set; }
        public string level { get; set; }
        public int TutorID { get; set; }
        public Tutor? Tutor { get; set; }
        public DateOnly? BirthDay { get; set; }
        [JsonIgnore]
        public ICollection<RegisterClasse>? rClasse { get; } = new List<RegisterClasse>();
        [JsonIgnore]
        public ICollection<Note>? notes { get; } = new List<Note>();
        [JsonIgnore]
        public ICollection<MissOrHier>? missOrHiers { get; } = new List<MissOrHier>();
        [JsonIgnore]
        public ICollection<PaidSubscribe>? paidSubscribes { get; } = new List<PaidSubscribe>();
       
    }
}
