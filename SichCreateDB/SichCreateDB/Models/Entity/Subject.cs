using System.Collections.Generic;

namespace SichCreateDB.Models.Entity
{
    public class Subject
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Couple Couple { get; set; }

        public List<TeacherSubject> TeacherSubjects { get; set; }
        public List<SubjectType> SubjectTypes { get; set; }
        public List<SubjectCourseSpecialization> SubjectCourseSpecializations { get; set; }
    }
}
