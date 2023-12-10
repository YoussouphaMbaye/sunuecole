namespace sunuecole.models
{
    public class RespMarkStudents
    {
        public int mark { get; set; }
        public int points { get; set; }
        public Lesson lesson { get; set; }
        public Evaluation evaluation { get; set; }
        public Students student { get; set; }
    }
}
