using System;
using System.Collections.Generic;
using System.Text;

namespace SichCreateDB.Models.Entity
{
    public class Couple
    {
        public int Id { get; set; }

        public string RoomId { get; set; }
        public Room Room { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int DayTimeId { get; set; }
        public DayTime DayTime { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        public List<CoupleGroup> CoupleGroups { get; set; }
    }
}
