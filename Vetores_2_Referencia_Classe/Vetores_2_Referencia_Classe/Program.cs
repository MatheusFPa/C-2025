using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_2_Referencia_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            
            for(int i = 0; i < n; i++)
            {                
                Console.WriteLine("Digite o nome do produto: ");
                string name = Console.ReadLine();
                Console.WriteLine("Digite o preço: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }
            Console.WriteLine("A soma dos produtos é " + sum.ToString("F2",CultureInfo.InvariantCulture));
            double avg = sum / n;
            Console.WriteLine("Average Price: " + avg.ToString("F2",CultureInfo.InvariantCulture));


        }
    }
}
