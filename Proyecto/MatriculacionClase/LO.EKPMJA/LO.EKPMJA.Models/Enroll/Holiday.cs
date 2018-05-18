using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.EKPMJA.Models.Enroll
{
    public class Holiday
    {
        public Guid HolidayId { get; set; }

        public string HolidayName { get; set; }

        public DateTime HolidayDate { get; set; }
    }
}
