using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace sunuecole.models
{
    public class Agents
    {
        [Key]
        public int IdAgents { get; set; }
        public string NameAgents { get; set; }
        public string? EmailAgents{ get; set; }
        public string? PhoneAgents { get; set; }
        public string? Profile { get; set; }
        public char sexe { get; set; }
        public DateOnly BirthDay { get; set; }
        [JsonIgnore]
        public ICollection<Orders>? Orders { get; } = new List<Orders>();
        [JsonIgnore]
        public ICollection<PaidSubscribe>? paidSubscribes { get; } = new List<PaidSubscribe>();
    }
}
