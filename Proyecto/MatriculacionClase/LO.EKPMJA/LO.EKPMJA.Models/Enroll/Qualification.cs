using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.EKPMJA.Models.Enroll
{
    public class Qualification
    {
        public Guid QualificationId { get; set; }

        public string Activity { get; set; }

        public float Score { get; set; }
    }
}
