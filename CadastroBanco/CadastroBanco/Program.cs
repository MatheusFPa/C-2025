using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CadastroBanco
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre o número da conta: ");
            int contaNumero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre o titular da conta: ");
            string nome_ = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)?");
            string dpInicial = Console.ReadLine();
            if (dpInicial == "n")
            {
                double value = 0.00;
                Cadastro cd = new Cadastro(contaNumero, nome_, dpInicial, value);
                Console.WriteLine("Conta " + cd.Nome + ", Titular: " + cd.NumConta + ", Saldo: " + cd.Valor.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine();

                Console.Write("Entre um valor para deposito: ");
                value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cd.add(value);
                //cd = new Cadastro(contaNumero, nome_, dpInicial, valor);
                Console.WriteLine("Dadados da conta atualizados: ");
                Console.WriteLine("Conta " + cd.Nome + ", Titular: " + cd.NumConta + ", Saldo: " + cd.Valor.ToString("F2", CultureInfo.InvariantCulture));

                Console.Write("Entre um valor para saque: ");
                value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cd.Remover(value);
                //cd = new Cadastro(contaNumero, nome_, dpInicial, valor);
                Console.WriteLine("Dadados da conta atualizados: ");
                Console.WriteLine("Conta " + cd.Nome + ", Titular: " + cd.NumConta + ", Saldo: " + cd.Valor.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.Write("Entre o valor de deposito inicial: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Cadastro cd = new Cadastro(contaNumero, nome_, dpInicial, valor);
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine("Conta " + cd.Nome + ", Titular: " + cd.NumConta + ", Saldo: " + cd.Valor.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine();

                Console.Write("Entre um valor para deposito: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cd.add(valor);
                //cd = new Cadastro(contaNumero, nome_, dpInicial, valor);
                Console.WriteLine("Dadados da conta atualizados: ");
                Console.WriteLine("Conta " + cd.Nome + ", Titular: " + cd.NumConta + ", Saldo: " + cd.Valor.ToString("F2", CultureInfo.InvariantCulture));

                Console.Write("Entre um valor para saque: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cd.Remover(valor);
                //cd = new Cadastro(contaNumero, nome_, dpInicial, valor);
                Console.WriteLine("Dadados da conta atualizados: ");
                Console.WriteLine("Conta " + cd.Nome + ", Titular: " + cd.NumConta + ", Saldo: " + cd.Valor.ToString(CultureInfo.InvariantCulture));
            }
        }
    }
}
