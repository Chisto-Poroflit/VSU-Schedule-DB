namespace SichCreateDB.Models.Entity
{
    public class TeacherTime
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int DayTimeId { get; set; }
        public DayTime DayTime { get; set; }
    }
}
