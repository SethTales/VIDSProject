using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VIDSProject.Models;
using VIDSProject.Services.Interfaces;

namespace VIDSProject.Services.Implementations
{
    public class ExposedCalculator : IExposedCalculatorService
    {
        public decimal CalculateNumberOfExposedIndividuals(DiseaseStateDto diseaseStateDto)
        {
            var susceptiblePortionOfPopulation =
                diseaseStateDto.NumberOfSusceptibleIndivudals / diseaseStateDto.TotalPopulation;
            var averagePeopleInfectedPerInfectiousPerson =
                diseaseStateDto.BasicReproductiveNumber / diseaseStateDto.MeanInfectiousPeriodInDays;
            var numberOfPeopleExposedOverAverageLatency =
                diseaseStateDto.NumberOfLatentIndividuals / diseaseStateDto.MeanLatentPeriodInDays;
            var rateOfChangeInExposedCount = susceptiblePortionOfPopulation *
                                                 (averagePeopleInfectedPerInfectiousPerson *
                                                  diseaseStateDto.NumberOfInfectiousIndividuals +
                                                  diseaseStateDto.ForceOfBaselineInfection) -
                                                  numberOfPeopleExposedOverAverageLatency;
            return decimal.Round(rateOfChangeInExposedCount, 2, MidpointRounding.AwayFromZero);
        }
    }
}
