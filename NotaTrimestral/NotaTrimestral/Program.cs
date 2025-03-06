using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaTrimestral
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno all = new Aluno();

            Console.Write("Nome do aluno: ");
            all.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");

            String[] Vet = Console.ReadLine().Split(' ');
            all.Nota1 = double.Parse(Vet[0], CultureInfo.InvariantCulture);
            all.Nota2 = double.Parse(Vet[1], CultureInfo.InvariantCulture);
            all.Nota3 = double.Parse(Vet[2], CultureInfo.InvariantCulture);
                     

            if (all.Aprovado())
            {
                Console.WriteLine("Nota Final = " + all.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Nota Final = " + all.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reprovado");
                Console.WriteLine("Fataram " + all.Resto().ToString("F2", CultureInfo.InvariantCulture) + " Pontos");
            }
        }
    }
}
