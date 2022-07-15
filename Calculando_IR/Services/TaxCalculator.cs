using Calculando_IR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculando_IR.Services
{
    public class TaxCalculator : TaxesList, ITaxCalculator
    {
        public TaxesList taxList { get; private set; }

        public TaxCalculator(TaxesList taxList)
        {
            this.taxList = taxList;
        }

        public double TaxCalculation(double value)
        {
            TaxItem taxItem = taxList.Find(value);

            return value * taxItem.Aliquot - taxItem.Deduction;
        }
    }
}
