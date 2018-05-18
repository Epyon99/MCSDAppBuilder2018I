using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.EKPMJA.Models.Common
{
    public abstract class Person
    {
        public Guid PersonId { get; set; }

        public string PersonaFullName { get; set; }

        public DateTime BirthDate { get; set; }

        public string BirthCountry { get; set; }

        public List<string> Nationalities { get; set; }

        public string Address { get; set; }

        public string BloodType { get; set; }

        public string CivilStatus { get; set; }

        public string IdentificatorCode { get; set; }

        public string Occupation { get; set; }

        /// <summary>
        /// Lista caracteristicas de la persona, fisicas o psicologicas, enfermedades conocidas
        /// u otros
        /// </summary>
        public List<Feature> Features { get; set; }
    }
}
