using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VIDSProject.Models;
using VIDSProject.Services.Interfaces;

namespace VIDSProject.Services.Implementations
{
    public class SusceptibleCalculator : ISusceptibleCalculatorService
    {
        public decimal CalculateNumberOfSusceptibleIndividuals(DiseaseStateDto diseaseStateDto)
        {
            var susceptiblePortionOfPopulation =
                diseaseStateDto.NumberOfSusceptibleIndivudals / diseaseStateDto.TotalPopulation;
            var averagePeopleInfectedPerInfectiousPerson =
                diseaseStateDto.BasicReproductiveNumber / diseaseStateDto.MeanInfectiousPeriodInDays;
            var rateOfChangeInSusceptibleCount = -susceptiblePortionOfPopulation *
                                                 (averagePeopleInfectedPerInfectiousPerson *
                                                  diseaseStateDto.NumberOfInfectiousIndividuals +
                                                  diseaseStateDto.ForceOfBaselineInfection);
            return decimal.Round(rateOfChangeInSusceptibleCount, 2, MidpointRounding.AwayFromZero);
        }   
    }
}
