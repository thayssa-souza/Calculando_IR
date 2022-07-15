using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculando_IR.Services
{
    public interface ITaxCalculator
    {
        double TaxCalculation(double value, out double totalTax);
    }
}
