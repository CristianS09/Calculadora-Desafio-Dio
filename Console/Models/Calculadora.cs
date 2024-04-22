using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Console.Models
{
    public class Calculadora
    {
        // Método Somar.
        public int Somar(int val1, int val2)
        {
            int resultadoSoma = val1 + val2;
            return resultadoSoma;
        }

        // Método Subtrair.
        public int Subtrair(int val1, int val2)
        {   
            int resultadoSubtrair = val1 - val2;
            return resultadoSubtrair;
        }

        // Método Dividir.

        public int Dividir(int val1, int val2)
        {
            int resultadoDividir = val1 / val2;
            return resultadoDividir;
        }

        //Método Multiplicar.
        public int Multiplicar(int val1, int val2)
        {
            int resultadoMultiplicar = val1 * val2;
           return resultadoMultiplicar;
        }
        
    }
}