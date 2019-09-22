using System.Collections.Generic;

namespace SichCreateDB.Models.Entity
{
    public class Para
    {
        public int Number { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public Couple Couple { get; set; }
    }
}
