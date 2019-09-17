using System;
using System.Collections.Generic;
using System.Text;

namespace SichCreateDB.Models.Entity
{
    public class Type
    {
        public string TypeId { get; set; }

        public List<RoomType> TypeRoom { get; set; }
        public List<SubjectType> SubjectTypes { get; set; }
    }
}
