using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.EKPMJA.Models.Enroll
{
    /// <summary>
    /// Un ciclo es la definicion fija donde esta la estructura de una carrera
    /// </summary>
    public class Cycle
    {
        public Guid CycleId { get; set; }

        public string CycleName { get; set; }

        public List<Course> Courses { get; set; }

        public Guid CareerId { get; set; }

        public virtual Career Career { get; set; }

        /// <summary>
        /// Duracion del ciclo en meses
        /// </summary>
        public int Length { get; set; }

    }
}
