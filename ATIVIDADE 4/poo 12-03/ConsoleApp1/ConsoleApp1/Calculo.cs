using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


 
    public class Calculo
    {
        private double Resultado;
        public double ValorA;
        public double ValorB;

        public void CalcularSoma() 
        {
            Resultado = ValorA + ValorB;
        }
        public void CalcularSubtração()
        {
            Resultado = ValorA - ValorB;
        }
        public void CalcularMultiplicação()
        {
            Resultado = ValorA * ValorB;
        }

        public void RetornarMaior()
        {

        }
        public void SomarGeral()
        {

        }
        public void ImprimirResultado()
        {
            Console.Write(Resultado);
        }
        public void ExecutarCalculadora()
        {

        }
    }
}
