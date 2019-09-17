using System;
using System.Collections.Generic;
using System.Text;

namespace SichCreateDB.Models.Entity
{
    public class SubjectType
    {
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        public string TypeId { get; set; }
        public Type Type { get; set; }
    }
}
