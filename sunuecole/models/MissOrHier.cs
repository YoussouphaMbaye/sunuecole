using System.ComponentModel.DataAnnotations;

namespace sunuecole.models
{
    public class MissOrHier
    {
        [Key]
        public int idMissOrHier { get; set; }
        public string name { get; set; }
        public Boolean MissingOrHier { get; set; }
        public TimeOnly HourComing { get; set; }
        public DateOnly DayComing { get; set; }
        public int doClasseId { get; set; }
        public DoClasse? doClasse { get; set; }
        public int studentId { get; set; }
        public Students? student { get; set; }
    }
}
