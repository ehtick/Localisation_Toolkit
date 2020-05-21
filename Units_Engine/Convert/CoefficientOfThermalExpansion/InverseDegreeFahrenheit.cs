﻿/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2020, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UN = UnitsNet; //This is to avoid clashes between UnitsNet quantity attributes and BHoM quantity attributes
using UnitsNet.Units;

using System.ComponentModel;
using BH.oM.Reflection.Attributes;
using BH.oM.Quantities.Attributes;
using UnitsNet;

namespace BH.Engine.Units
{
    public static partial class Convert
    {
        [Description("Convert SI units (inverse Kelvins) into inverse degress Fahrenheit")]
        [Input("inverseKelvins", "The number of inverse Kelvins to convert", typeof(ThermalExpansionCoefficient))]
        [Output("inverseDegreesFahrenheit", "The number of inverse degrees Fahrenheit")]
        public static double ToInverseDegreeFahrenheit(this double inverseKelvins)
        {
            UN.QuantityValue qv = inverseKelvins;
            return UN.UnitConverter.Convert(qv, CoefficientOfThermalExpansionUnit.InverseKelvin, CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit);
        }

        [Description("Convert inverse degrees Fahrenheit into SI units (inverse Kelvins)")]
        [Input("inverseDegreesFahrenheit", "The number of inverse degrees Fahrenheit to convert")]
        [Output("inverseKelvins", "The number of inverse kelvins", typeof(ThermalExpansionCoefficient))]
        public static double FromInverseDegreeFahrenheit(this double inverseDegreesFahrenheit)
        {
            UN.QuantityValue qv = inverseDegreesFahrenheit;
            return UN.UnitConverter.Convert(qv, CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit, CoefficientOfThermalExpansionUnit.InverseKelvin);
        }
    }
}
