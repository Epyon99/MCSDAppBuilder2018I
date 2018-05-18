using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.EKPMJA.Models.Enroll
{
    /// <summary>
    /// Categoria de cursos que pertenece a un ciclo
    /// </summary>
    public class Course
    {
        public Guid CourseId { get; set; }

        public string CourseName { get; set; }

        public Guid CycleId { get; set; }

        public virtual Cycle Cycle { get; set; }

        public int Credits { get; set; }

        public int AcademicPracticeDuration { get; set; }

        public int AcademicTheoryDuration { get; set; }

        /// <summary>
        /// Los cursos que lo preceden
        /// </summary>
        public List<Guid> PrecedingsCourse { get; set; }

        /// <summary>
        /// El curso que bloquea
        /// </summary>
        public Guid? BlockingCourse { get; set; }

        public string EvaluationType { get; set; }

        public string CourseType { get; set; }

        public bool IsMandatory { get; set; }
    }
}
