using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VIDSProject.Models;

namespace VIDSProject.Services.Interfaces
{
    interface IInfectiousCalculatorService
    {
        decimal CalculateNumberOfInfectiousIndividuals(DiseaseStateDto diseaseStateDto);
    }
}
