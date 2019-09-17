using System;
using System.Collections.Generic;
using System.Text;

namespace SichCreateDB.Models.Entity
{
    public class RoomTime
    {
        public string RoomId { get; set; }
        public Room Room { get; set; }

        public int DayTimeId { get; set; }
        public DayTime DayTime { get; set; }
    }
}
