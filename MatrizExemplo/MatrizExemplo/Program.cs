using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            // vai retornar os valores em que estiver na posição i e da posição i referenciada da linha na coluna da matriz
            Console.WriteLine("Main Diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write((mat[i, i] + ", "));
            }
            Console.WriteLine();

            int count = 0;
            List<int> negatives = new List<int>();
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                        negatives.Add(mat[i, j]);
                    }
                }
            }
            Console.WriteLine("Count of Negatives Number: " + count);
            Console.WriteLine("List of negative numbers: " + string.Join(", ", negatives));
        }
    }
}
