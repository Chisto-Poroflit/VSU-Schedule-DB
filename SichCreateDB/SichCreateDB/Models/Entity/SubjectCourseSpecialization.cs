using System;
using System.Collections.Generic;
using System.Text;

namespace SichCreateDB.Models.Entity
{
    public class SubjectCourseSpecialization
    {
        public int CourseSpecId { get; set; }
        public CourseSpecialization CourseSpecialization { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
