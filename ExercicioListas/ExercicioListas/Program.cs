using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre nº de funcionarios: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list1 = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionario #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list1.Add(new Funcionario(id, name, salary));
                Console.WriteLine();
            }
            Console.WriteLine("Entre com o funcionario que tera aumento de salario: ");
            int searchid = int.Parse(Console.ReadLine());

            Funcionario func = list1.Find(x => x.Id == searchid);
            if (func != null)
            {

                Console.WriteLine("Entre a porcentagem: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                func.AumentarSalario(percent);
            }
            else
            {
                Console.WriteLine("Id não existe");
            }
            Console.WriteLine();
            Console.WriteLine("Lista de funcionário atualizada: ");
            foreach (Funcionario obj in list1)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
