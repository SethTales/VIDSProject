using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VIDSProject.Models;
using VIDSProject.Services.Interfaces;

namespace VIDSProject.Services.Implementations
{
    public class InfectiousCalculator : IInfectiousCalculatorService
    {
        public decimal CalculateNumberOfInfectiousIndividuals(DiseaseStateDto diseaseStateDto)
        {
            var numberOfExposedPeopleOverAverageLatency =
                diseaseStateDto.NumberOfLatentIndividuals / diseaseStateDto.MeanLatentPeriodInDays;
            var numberOfInfectedPeopleOverAverageInfectiousPeriod =
                diseaseStateDto.NumberOfInfectiousIndividuals / diseaseStateDto.MeanInfectiousPeriodInDays;
            return decimal.Round(numberOfExposedPeopleOverAverageLatency - numberOfInfectedPeopleOverAverageInfectiousPeriod, 2, MidpointRounding.AwayFromZero);
        }
    }
}
