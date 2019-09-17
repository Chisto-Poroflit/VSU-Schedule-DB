using System;
using System.Collections.Generic;
using System.Text;

namespace SichCreateDB.Models.Entity
{
    public class Group
    {
        public int Id { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public string SpecializatioName { get; set; }
        public Specialization Specialization { get; set; }

        public List<CoupleGroup> CoupleGroups { get; set; }
        public List<GroupTime> GroupTimes { get; set; }
    }
}
