using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(vet[j]);
                }
            }
            int valor = int.Parse(Console.ReadLine());
            List<int> position = new List<int>();

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] == valor)
                    {
                        Console.WriteLine("Position: " + i + ", " + j + ":");

                    }
                }

            }


        }
    }
}
