using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.EKPMJA.Models.Enroll
{
    public class EnrolledStudent
    {
        public Guid EnrolledStudentId { get; set; }

        public Guid StudentId { get; set; }

        public Guid AvailableCourseId { get; set; }

        public float Average { get; set; }

        public List<Qualification> Qualification { get; set; }

        public List<Assistance> Assistances { get; set; }

        public bool IsActive { get; set; }

        public bool IsRepetition { get; set; }
    }
}
