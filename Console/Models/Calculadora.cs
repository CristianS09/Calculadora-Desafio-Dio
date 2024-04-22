using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Console.Models
{
    public class Calculadora
    {

        public int Somar(int val1, int val2)
        {
            int resultadoSoma = val1 + val2;
            return resultadoSoma;
        }

        public int Subtrair(int val1, int val2)
        {   
            int resultadoSubtrair = val1 - val2;
            return resultadoSubtrair;
        }

        public int Dividir(int val1, int val2)
        {
            int resultadoDividir = val1 / val2;
            return resultadoDividir;
        }

        public int Multiplicar(int val1, int val2)
        {
            int resultadoMultiplicar = val1 * val2;
           return resultadoMultiplicar;
        }
        
    }
}