﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SichCreateDB.Models.Entity
{
    public class Group
    {
        public int Id { get; set; }

        public int SemesterNumber { get; set; }

        public int GroupNumber { get; set; }

        public int SubgroupNumber { get; set; }

        public int SpecializatioId { get; set; }
        public Specialization Specialization { get; set; }

        public List<CoupleGroup> CoupleGroups { get; set; }
    }
}
