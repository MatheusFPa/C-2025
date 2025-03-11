using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroBancoCorrigido
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro cadastro;
            Console.Write("Entre o número da conta: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            String Name = Console.ReadLine();
            Console.Write("Haverá deposito incial (s/n)? ");
            string inicial = Console.ReadLine();
            if (inicial == "s" || inicial == "S")
            {
                Console.Write("Entre com o valor inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                cadastro = new Cadastro(num, Name, depositoInicial);
            }
            else
            {
                cadastro = new Cadastro(num, Name);
            }

            Console.WriteLine();

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(cadastro);

            Console.WriteLine();

            Console.Write("Entre um valor para depositar:");
            double Qtd = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            cadastro.Depositar(Qtd);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(cadastro);

            Console.WriteLine();

            Console.Write("Entre um valor para sacar:");
            Qtd = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            cadastro.Sacar(Qtd);
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(cadastro);

        }
    }
}
