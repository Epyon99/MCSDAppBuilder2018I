using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.EKPMJA.Models.Enroll
{
    public class RegisteredStudent
    {
        public Guid RegisteredStudentId { get; set; }

        public Guid StudentId { get; set; }

        public int Credits { get; set; }

        public List<AvailableCourse> EnrollCourses { get; set; }

        public Guid WorkCycleId { get; set; }

        public WorkCycle WorkCycle { get; set; }
    }
}
