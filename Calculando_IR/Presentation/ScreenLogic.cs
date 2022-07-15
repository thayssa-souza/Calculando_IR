using Calculando_IR.Domain;
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
        TaxesList taxList;

        TaxCalculator clientTaxCalculator;
        public double taxValue;

        public ScreenLogic()
        {
            taxList = new TaxesList();

            taxList.AddItem(0, 22847.76, 0, 0);
            taxList.AddItem(22847.77, 33919.80, 0.075, 1713.58);
            taxList.AddItem(33919.81, 45012.60, 0.150, 4257.57);
            taxList.AddItem(45012.61, 55976.16, 0.225, 7633.51);
            taxList.AddItem(55976.16, 999999999.99, 0.275, 10432.32);

            clientTaxCalculator = new TaxCalculator(taxList);

        }

        public void run()
        {

            ScreenPresentation screenPresentation = new ScreenPresentation();
            screenPresentation.WelcomeMessage();

            screenPresentation.ResquestInput();
            string answerValue = Console.ReadLine();
            bool validationsOK = Validations.ValidValue(answerValue, out double annualValue);

            if (validationsOK)
            {
                Console.Clear();
                taxValue = clientTaxCalculator.TaxCalculation(annualValue);
                screenPresentation.FinalMessage(taxValue);
            }
            else 
            {
                screenPresentation.ErrorMessage();
            }
        }
    }
}
