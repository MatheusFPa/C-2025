using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "Tv 4k";

            Console.WriteLine( p.Nome);
            Console.WriteLine( p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }
}
