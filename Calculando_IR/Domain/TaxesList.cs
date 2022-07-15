using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculando_IR.Domain
{
    public class TaxesList
    {
        public List<TaxItem> TaxesTable { get; private set; }

        public TaxesList()
        {
            TaxesTable = new List<TaxItem>();
        }

        public void AddItem(double minValue, double maxValue, double aliquot, double deduction)
        {
            TaxItem taxItem = new TaxItem(minValue, maxValue, aliquot, deduction);

            TaxesTable.Add(taxItem);
        }

        public TaxItem Find(double wage)
        {
            return TaxesTable.Find(taxItem => wage >= taxItem.MinValue && wage <= taxItem.MaxValue);
        }
    }
}
