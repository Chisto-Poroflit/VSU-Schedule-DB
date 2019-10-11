
using System.Collections.Generic;

namespace DbLibrary.Models.Entity
{
    public class Subject
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Semester { get; set; }

        public List<Couple> Couples { get; set; }
        public CurriculumUnit CurriculumUnit { get; set; }
    }
}
