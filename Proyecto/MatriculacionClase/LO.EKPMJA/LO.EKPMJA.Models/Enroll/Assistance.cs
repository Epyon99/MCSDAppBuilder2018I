using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.EKPMJA.Models.Enroll
{
    public class Assistance
    {
        public Guid AssistanceId { get; set; }
        
        public DateTime Day { get; set; }

        public bool Assisted { get; set; }
    }
}
