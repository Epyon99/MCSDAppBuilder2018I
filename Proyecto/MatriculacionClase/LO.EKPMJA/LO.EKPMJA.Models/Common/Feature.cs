using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.EKPMJA.Models.Common
{
    public class Feature
    {
        public Guid FeatureId { get; set; }

        public string FeatureName { get; set; }

        public string Description { get; set; }

        public DateTime OriginDate { get; set; }

        public string MedicalCondition { get; set; }
    }
}
