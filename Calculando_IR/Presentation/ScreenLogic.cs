using Calculando_IR.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculando_IR.Presentation
{
    public class ScreenLogic
    {
        TaxCalculator clientTaxCalculator = new TaxCalculator();
        public double taxValue;

        public void run()
        {
            ScreenPresentation screenPresentation = new ScreenPresentation();
            screenPresentation.WelcomeMessage();

            screenPresentation.ResquestInput();
            string answerValue = Console.ReadLine();
            Validations.ValidValue(answerValue, out double annualValue);

            Console.Clear();

            clientTaxCalculator.TaxCalculation(annualValue, out double taxValue);


            screenPresentation.FinalMessage(taxValue);
        }
    }
}
