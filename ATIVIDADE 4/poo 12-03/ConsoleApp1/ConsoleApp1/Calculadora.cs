using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculadora
    {
        Calculo _calculo= new Calculo();    
        public void ExecutarCalculadora()
        {
            LerValores();
            _calculo.CalcularSoma();
            _calculo.ImprimirResultado();
        }
        public void LerValores() 
        {
            Console.Write("Digite o valor de A");
            _calculo.ValorA=int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B");
            _calculo.ValorB = int.Parse(Console.ReadLine());
        }
    }
}
