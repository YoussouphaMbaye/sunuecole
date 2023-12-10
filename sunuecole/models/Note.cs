using System.ComponentModel.DataAnnotations;

namespace sunuecole.models
{
    public class Note:BaseEntity
    {
        [Key]
        public int idNote { get; set; }
        public int mark { get; set; }
        public int evaluationId { get; set; }
        public Evaluation? evaluation { get; set; }
        public int studentId { get; set; }
        public Students? student { get; set; }
    }
}
