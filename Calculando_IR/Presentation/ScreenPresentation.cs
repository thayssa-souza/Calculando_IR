using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculando_IR.Presentation
{
    public class ScreenPresentation
    {
        public void WelcomeMessage()
        {
            Console.WriteLine("Seja bem-vindo a Calculadora de Imposto de Renda para Pessoas Físicas");
        }

        public void ResquestInput()
        {

            Console.WriteLine("Digite seu rendimento anual: R$");
        }

        public void FinalMessage(double taxValue)
        {
            Console.WriteLine($"Total de imposto a ser pago de acordo com a sua renda: R$ {taxValue}");
        }
    }
}
