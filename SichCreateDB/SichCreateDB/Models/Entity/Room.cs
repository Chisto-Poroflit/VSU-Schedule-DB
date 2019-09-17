using System;
using System.Collections.Generic;
using System.Text;

namespace SichCreateDB.Models.Entity
{
    public class Room
    {
        public string Number { get; set; }

        public Couple Couple { get; set; }

        public List<RoomType> TypeRoom { get; set; }

        public List<RoomTime> RoomTimes { get; set; }
    }
}
