using System.Collections.Generic;

namespace SichCreateDB.Models.Entity
{
    public class Teacher
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public Couple Couple { get; set; }

        public List<TeacherTime> TeachersTimes { get; set; }
        public List<TeacherSubject> TeacherSubjects { get; set; }
    }
}
