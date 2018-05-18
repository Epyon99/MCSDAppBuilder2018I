using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.EKPMJA.Models.Enroll
{
    /// <summary>
    /// Cursos asignados a un profesor
    /// </summary>
    public class TeacherCourse
    {
        public Guid TeacherCourseId { get; set; }

        public Guid TeacherId { get; set; }

        public Teacher Teacher { get; set; }

        public Guid AvailableCourseId { get; set; }

        public AvailableCourse AvailableCourse { get; set; }

        public bool IsActive { get; set; }

        /// <summary>
        /// Informacion y clases del curso de forma estructurada
        /// </summary>
        public List<string> CourseMaterial { get; set; }

    }
}
