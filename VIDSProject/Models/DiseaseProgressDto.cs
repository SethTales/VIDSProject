using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VIDSProject.Models
{
    public class DiseaseProgressDto
    {
        public DiseaseStateDto InputDiseaseStateDto { get; set; }
        public DiseaseStateDto OutputDiseaseStateDto { get; set; }
        public int NumberOfDaysSinceInitialOutbreak { get; set; }
        public decimal CurrentSusceptibleInvdividuals { get; set; }
        public decimal CurrentExposedIndividuals { get; set; }
        public decimal CurrentInfectiousIndividuals { get; set; }
        public decimal TotalFatalities { get; set; }
        public decimal TotalRecovered { get; set; }
    }
}
