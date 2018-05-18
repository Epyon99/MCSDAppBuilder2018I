using System;
using System.Collections.Generic;

namespace LO.EKPMJA.Models.Enroll
{
    public class Career
    {
        public Guid CareersId { get; set; }

        public string CareerName { get; set; }

        public int Cycles { get; set; }

        public string Faculty { get; set; }

        public List<Cycle> CyclesCollection { get; set; }

    }
}
