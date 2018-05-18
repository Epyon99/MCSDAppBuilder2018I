using LO.EKPMJA.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.EKPMJA.Models.Enroll
{
    public class Teacher : Person
    {
        public List<string> EnrolledCourses { get; set; }

        public List<string> CapableCourses { get; set; }

        public string AcademicDegree { get; set; }

        public Schedule AvailableSchedules { get; set; }

        public List<string> Certificates { get; set; }
    }
}
