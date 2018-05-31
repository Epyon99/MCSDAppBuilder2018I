using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LO.EKPMJA.Models.Enroll
{
    [Table("Carreras")]
    public class Career
    {
        [Key]
        [Column("ID")]
        public Guid CareersId { get; set; }

        public string CareerName { get; set; }

        public int Cycles { get; set; }

        public string Faculty { get; set; }

        public List<Cycle> CyclesCollection { get; set; }

    }
}
