using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using VIDSProject.Models;
using VIDSProject.Services.Implementations;

namespace VIDSProjectTests.UnitTests.ServiceTests
{
    [TestFixture]
    public class InfectiousCalculatorTests
    {
        [Test]
        public void CalculateNumberOfInfectiousIndividuals_ReturnsExpectedCount()
        {
            var diseaseStateDto = new DiseaseStateDto
            {
                TotalPopulation = 1000,
                BasicReproductiveNumber = 2.68M,
                ForceOfBaselineInfection = 10,
                MeanInfectiousPeriodInDays = 10,
                MeanLatentPeriodInDays = 4,
                NumberOfInfectiousIndividuals = 0,
                NumberOfLatentIndividuals = 10,
                NumberOfSusceptibleIndivudals = 980
            };
            var exposedCalculator = new InfectiousCalculator();
            var expectedInfectious = 2.5M;

            var actualInfectious = exposedCalculator.CalculateNumberOfInfectiousIndividuals(diseaseStateDto);

            Assert.AreEqual(expectedInfectious, actualInfectious);
        }
    }
}
