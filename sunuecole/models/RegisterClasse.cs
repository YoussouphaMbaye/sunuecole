using System.ComponentModel.DataAnnotations;

namespace sunuecole.models
{
    public class RegisterClasse:BaseEntity
    {
        [Key]
        public int IdRegisterClasse { get; set; }
        public int schoolYearID { get; set; }
        public int classeID { get; set; }
        public int studentsId { get; set; }
        public SchoolYear? schoolYear { get; set; }
        public Classe? classe { get; set; }
        public Students? students { get; set; }
    }
}
