using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.EKPMJA.Models.Enroll
{
    /// <summary>
    /// El Ciclo activo de la universidad para los estudiantes de multiples 
    /// carreras cursas
    /// </summary>
    public class WorkCycle
    {
        public Guid WorkCycleId { get; set; }

        public string WorkCycleName { get; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<Holiday> Holidays { get; set; }

        public List<string> AvailableCourses { get; set; }

        public List<Career> Careers { get; set; }

        public List<string> RegisteredStudents { get; set; }

    }
}
