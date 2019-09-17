using System;
using System.Collections.Generic;
using System.Text;

namespace SichCreateDB.Models.Entity
{
    public class CourseSpecialization
    {
        public int Id { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public string SpecName { get; set; }
        public Specialization Specialization { get; set; }

        public List<SubjectCourseSpecialization> SubjectCourseSpecializations { get; set; }
    }
}
