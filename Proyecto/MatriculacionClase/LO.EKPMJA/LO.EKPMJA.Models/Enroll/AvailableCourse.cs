using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.EKPMJA.Models.Enroll
{
    public class AvailableCourse
    {
        public Guid AvailableCourseId { get; set; }

        public Guid CourseId { get; set; }

        public Course Course { get; set; }

        public Guid WorkCycleId { get; set; }

        public WorkCycle WorkCycle { get; set; }

        public string Teacher { get; set; }

        public List<string> RegisteredStudents { get; set; }

        public string Section { get; set; }

        public Schedule Schedule { get; set; }


    }
}
