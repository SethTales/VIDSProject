using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using VIDSProject.Models;
using VIDSProject.Services.Implementations;

namespace VIDSProjectTests.UnitTests.ServiceTests
{
    [TestFixture]
    public class SusceptibleCalculatorTests
    {
        [Test]
        public void CalculateNumberOfSusceptibleIndividuals_ReturnsExpectedCount()
        {
            var diseaseStateDto = new DiseaseStateDto
            {
                TotalPopulation = 1000,
                BasicReproductiveNumber = 2.68M,
                ForceOfBaselineInfection = 10,
                MeanInfectiousPeriodInDays = 10,
                MeanLatentPeriodInDays = 4,
                NumberOfInfectiousIndividuals = 0,
                NumberOfLatentIndividuals = 0,
                NumberOfSusceptibleIndivudals = 990
            };
            var susceptibleCalculator = new SusceptibleCalculator();
            var expectedSusceptibleIndividuals = -9.9M;

            var actualSusceptibleIndividuals = susceptibleCalculator.CalculateNumberOfSusceptibleIndividuals(diseaseStateDto);

            Assert.AreEqual(expectedSusceptibleIndividuals, actualSusceptibleIndividuals);

        }
    }
}
