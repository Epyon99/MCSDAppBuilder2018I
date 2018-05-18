using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.EKPMJA.Models.Enroll
{
    public class CapableTeacherCourse
    {
        public Guid CapableTeacherCourseId { get; set; }

        public Guid TeacherId { get; set; }

        public Teacher Teacher { get; set; }

        public Guid CourseId { get; set; }

        public Course Course { get; set; }
    }
}
