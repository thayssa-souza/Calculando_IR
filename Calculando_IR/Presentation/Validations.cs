﻿using Calculando_IR.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Calculando_IR.Presentation
{
    public class Validations
    {
        public static bool ValidValue(string answerValue, out double value)
        {
            if (!double.TryParse(answerValue, out value) || value < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
