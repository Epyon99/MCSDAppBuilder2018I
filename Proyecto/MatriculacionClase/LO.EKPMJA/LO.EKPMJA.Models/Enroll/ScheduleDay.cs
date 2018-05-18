using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.EKPMJA.Models.Enroll
{
    public class ScheduleDay
    {
        public Guid ScheduleDayId { get; set; }

        public Guid ScheduleId { get; set; }

        public DayOfWeek Day { get; set; }

        public DateTime InitHour { get; set; }

        public DateTime EndHour { get; set; }

        public DateTime BreakStart { get; set; }

        public DateTime BreakEnd { get; set; }
    }
}
