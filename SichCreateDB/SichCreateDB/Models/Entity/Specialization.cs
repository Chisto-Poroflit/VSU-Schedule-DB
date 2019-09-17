using System;
using System.Collections.Generic;
using System.Text;

namespace SichCreateDB.Models.Entity
{
    public class Specialization
    {
        public string Name { get; set; }

        public Group Group { get; set; }

        public List<CourseSpecialization> CourseSpecializations { get; set; }
    }
}
