using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace TestDotNetVrSystem
{
    public class Task3
    {
        /*
         * Dada a lista de inteiros, retorne o somatório de todos os itens com valor POSITIVO da lista     
         * LEMBRANDO que 0 (zero) NÃO é um número positivo
         */
        public static int GetSum(List<int> list)
        {
            int sum = 0;

            foreach (int i in list)
            {
                if (i > 0)
                {
                    sum = sum + i;
                }
            }

            return sum;
        }
    }
}
