using Calculando_IR.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculando_IR.Domain
{
    public class Validations : TaxCalculator
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
