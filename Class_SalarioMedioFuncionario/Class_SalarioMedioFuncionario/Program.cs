using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_SalarioMedioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario P1 = new Funcionario();
            Funcionario P2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome: ");
            P1.N1 = Console.ReadLine();
            Console.Write("Salario: ");
            P1.S1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionario:");
            Console.Write("Nome: ");
            P2.N2 = Console.ReadLine();
            Console.Write("Salario: ");
            P2.S2 = double.Parse(Console.ReadLine());

            double media = ((P1.S1 + P2.S2) / 2.0);

            Console.WriteLine("Salario Médio = " + media.ToString("F2"),CultureInfo.InvariantCulture);
        }
    }
}
