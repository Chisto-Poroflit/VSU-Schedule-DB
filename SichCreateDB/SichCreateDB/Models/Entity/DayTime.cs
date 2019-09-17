using System.Collections.Generic;

namespace SichCreateDB.Models.Entity
{
    public class DayTime
    {
        public int Id { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string NumerOrDenomin { get; set; }

        public string Day { get; set; }

        public Couple Couple { get; set; }

        public List<TeacherTime> TeachersTimes { get; set; }
        public List<RoomTime> RoomTimes { get; set; }
        public List<GroupTime> GroupTimes { get; set; }
    }
}
