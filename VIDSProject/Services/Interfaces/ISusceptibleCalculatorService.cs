﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VIDSProject.Models;

namespace VIDSProject.Services.Interfaces
{
    public interface ISusceptibleCalculatorService
    {
        decimal CalculateNumberOfSusceptibleIndividuals(DiseaseStateDto diseaseStateDto);
    }
}
