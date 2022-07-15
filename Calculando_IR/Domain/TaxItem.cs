using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Calculando_IR.Domain
{
    public class TaxItem
    {
        public double MinValue { get; private set; }
        public double MaxValue { get; private set; }
        public double Aliquot { get; private set; }
        public double Deduction { get; private set; }

        public TaxItem(double minValue, double maxValue, double aliquot, double deduction)
        {
            this.MinValue = minValue;
            this.MaxValue = maxValue;
            this.Aliquot = aliquot;
            this.Deduction = deduction;
        }
    }
}
