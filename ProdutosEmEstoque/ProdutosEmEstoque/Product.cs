using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosEmEstoque
{
    class Product
    {
        public string Name;
        public double Price;
        public int Qtd;
      
        public double ValorTotalEmEstoque()
        {
            return Price * Qtd;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Qtd = Qtd + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Qtd = Qtd - quantidade;
        }

        public override string ToString()
        {
            return Name + ", $ " + Price.ToString("F2",CultureInfo.InvariantCulture) + ", " + Qtd + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
