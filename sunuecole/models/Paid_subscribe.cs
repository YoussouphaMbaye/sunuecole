using System.ComponentModel.DataAnnotations;

namespace sunuecole.models
{
    public class PaidSubscribe:BaseEntity
    {
        [Key]
        public int IdPaidSubscribe { get; set; }
        public String Status { get; set; }
        public string Pin { get; set; }
        public string PaymentMode { get; set; }
        public int studentsID { get; set; }
        public Students? student { get; set; }
        public int InfSubscribeID { get; set; }
        public InfSubscribe? infSubscribe { get; set; }
        public int AgentID { get; set; }
        public Agents? Agent { get; set; }
    }
}
