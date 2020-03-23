using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VIDSProject.Models
{
    public class DiseaseStateDto
    {
        /// <summary>
        /// S(t) - the number of susceptible individuals at time t
        /// </summary>
        public decimal NumberOfSusceptibleIndivudals { get; set; }

        /// <summary>
        /// N - The total population in the model
        /// </summary>
        public decimal TotalPopulation { get; set; }

        /// <summary>
        /// R-naught - the average number of individuals that one infectious individual will infect
        /// </summary>
        public decimal BasicReproductiveNumber { get; set; }

        /// <summary>
        /// Di - the average number of days an indivdual is infectious for
        /// </summary>
        public decimal MeanInfectiousPeriodInDays { get; set; }

        /// <summary>
        /// l(t) - the number of susceptible individuals at time t
        /// </summary>
        public decimal NumberOfInfectiousIndividuals { get; set; }

        /// <summary>
        /// z(t) - the baseline number of cases
        /// </summary>
        public decimal ForceOfBaselineInfection { get; set; }

        /// <summary>
        /// E(t) - the number of exposed individuals who are not yet infectious
        /// </summary>
        public decimal NumberOfLatentIndividuals { get; set; }

        /// <summary>
        /// DE - average number of days an individual is exposed but not infectious
        /// </summary>
        public decimal MeanLatentPeriodInDays { get; set; }
    }
}
