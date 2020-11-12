using System.Collections.Generic;
using TestDotNetVrSystem.HelpClasses;

namespace TestDotNetVrSystem
{
    public class Task7
    {
        /*
         * Desenvolma um método que retorne o nome dos produtos que estão com estoque zerado
         * Dica: A classe Repository possui as informções dos Products
         */
        public static List<string> GetProductsOutOfStock()
        {
            var repository = new Repository();
            List<string> produtosZerados = new List<string>();

            foreach (var item in repository.Products)
            {
                if (item.Stock.Quantity == 0)
                {
                    produtosZerados.Add(item.Name);
                }
            }

            return produtosZerados;
        }

        /*
        * Desenvolma um método que retorne a soma total das quantidades de estoque dos itens
        * Dica: A classe Repository possui as informções dos Products
        */
        public static int GetSumStock()
        {
            var repository = new Repository();
            int sumEstoque = 0;

            foreach (var item in repository.Products)
            {
                sumEstoque = sumEstoque + item.Stock.Quantity;
            }

            return sumEstoque;
        }

        /*
         * Crie um método que verifique, dado Id e quantidade solicitada do produto
         * se o mesmo possui quantidade em estoque para venda
         * Dica: A classe Repository possui as informções dos Products
         * 
         */
        public static bool IsSalePossible(int productId, int orderQuantity)
        {
            var repository = new Repository();
            var prod = repository.Products[productId];

            if (prod.Stock.Quantity >= orderQuantity)
                return true;
            else
                return false;
        }
    }
}
