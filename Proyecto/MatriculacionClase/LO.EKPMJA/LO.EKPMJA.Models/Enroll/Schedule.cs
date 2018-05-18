using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.EKPMJA.Models.Enroll
{
    public class Schedule
    {
        public Guid ScheduleId { get; set; }

        public string ScheduleName { get; set; }

        public List<ScheduleDay> Days { get; set; }

        public List<string> AvailableCourses { get; set; }
    }
}
