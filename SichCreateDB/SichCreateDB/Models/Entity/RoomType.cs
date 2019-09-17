using System;
using System.Collections.Generic;
using System.Text;

namespace SichCreateDB.Models.Entity
{
    public class RoomType
    {
        public string RoomNumber { get; set; }
        public Room Room { get; set; }

        public string TypeId { get; set; }
        public Type Type { get; set; }
    }
}
