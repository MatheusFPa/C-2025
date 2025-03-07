using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dola? ");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantos dolare voce vai comprar? ");
            double qtdDolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double result = ConversorMoeda.DolarEmReal(qtdDolar, cotacao);

            Console.WriteLine("Valor a ser pago em reais: " + result);
        }
    }
}
