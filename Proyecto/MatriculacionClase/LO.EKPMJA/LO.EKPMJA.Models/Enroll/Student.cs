using LO.EKPMJA.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.EKPMJA.Models.Enroll
{
    public class Student : Person
    {
        public List<Career> Careers { get; set; }

        public Guid ActiveCareers { get; set; }

        public Career ActiveCarrers { get; set; }

        public Guid ActiveCycleId { get; set; }

        public Cycle ActiveCycle { get; set; }

        public List<string> Matriculas { get; set; }

        /// <summary>
        /// Cursos de los que ha tomado parte
        /// </summary>
        public List<EnrolledStudent> EnrolledCourses { get; set; }

        public List<WorkCycle> EnrolledCycles { get; set; }

        public List<string> Teachers { get; set; }

    }
}
