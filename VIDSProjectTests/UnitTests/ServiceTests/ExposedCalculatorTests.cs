using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Internal;
using VIDSProject.Models;
using VIDSProject.Services.Implementations;

namespace VIDSProjectTests.UnitTests.ServiceTests
{
    [TestFixture]
    public class ExposedCalculatorTests
    {
        [Test]
        public void CalculateNumberOfExposedIndividuals_ReturnsExpectedCount()
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
            var exposedCalculator = new ExposedCalculator();
            var expectedExposed = 9.9M;

            var actualExposed = exposedCalculator.CalculateNumberOfExposedIndividuals(diseaseStateDto);

            Assert.AreEqual(expectedExposed, actualExposed);
        }
    }
}
