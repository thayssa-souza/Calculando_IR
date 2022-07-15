using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculando_IR.Services
{
    public class TaxCalculator : ITaxCalculator
    {
        public double TaxCalculation(double value, out double totalTax)
        {
            totalTax = 0;
            switch (value)
            {
                case <= 22847.76:
                    totalTax = value * 0;
                    break;

                case <= 33919.80:
                    totalTax = value * 0.075 - 1713.58;
                    break;

                case <= 45012.60:
                    totalTax = value * 0.15 - 4257.57;
                    break;

                case <= 55976.16:
                    totalTax = value * 0.225 - 7633.51;
                    break;

                case > 55976.16:
                    totalTax = value * 0.275 - 10432.32;
                    break;

                default:
                    break;
            }
            return totalTax;

        }
    }
}
