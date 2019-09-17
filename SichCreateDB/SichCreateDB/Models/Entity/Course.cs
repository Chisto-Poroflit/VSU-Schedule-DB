using System;
using System.Collections.Generic;
using System.Text;

namespace SichCreateDB.Models.Entity
{
    public class Course
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public string EducationType { get; set; }

        public Group Group { get; set; }

        public List<CourseSpecialization> CourseSpecializations { get; set; }
    }
}
