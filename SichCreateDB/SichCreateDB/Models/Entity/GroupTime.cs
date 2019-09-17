using System;
using System.Collections.Generic;
using System.Text;

namespace SichCreateDB.Models.Entity
{
    public class GroupTime
    {
        public int GroupId { get; set; }
        public Group Group { get; set; }

        public int DayTimeId { get; set; }
        public DayTime DayTime { get; set; }
    }
}
