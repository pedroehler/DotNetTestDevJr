using System;
using System.Collections.Generic;

namespace TestDotNetVrSystem
{
    public class Task6
    {
        /*
         * Dada uma lista de inteiros, crie um método que devolva a proporção de números positos, negativos e zeros, respectivamente.
         * Obs.: Retornar valores com 6 casas decimais
         * Ex.:
         * Entrada:
         * -4 3 -9 0 4 1    
         * Saída: 
         * 0.500000
         * 0.333333
         * 0.166667
         */
        public static List<decimal> GetRatios(List<int> numbers)
        {
            decimal positivosCont = 0;
            decimal negativosCont = 0;
            decimal zerosCont = 0;

            foreach (int i in numbers)
            {   
                if (i > 0)
                    positivosCont++;
                else if (i < 0)
                    negativosCont++;
                else if (i == 0)
                    zerosCont++;
            }

            List<decimal> proporcao = new List<decimal>();

            proporcao.Add(Math.Round(positivosCont / numbers.Count, 6));
            proporcao.Add(Math.Round(negativosCont / numbers.Count, 6));
            proporcao.Add(Math.Round(zerosCont / numbers.Count, 6));

            return proporcao;
        }
    }
}
