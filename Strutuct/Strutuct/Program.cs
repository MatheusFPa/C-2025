using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strutuct
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<double> x = null;  // Primeira forma de escrita Nullable
            double? y = 10.0;           // Segunda forma de escrita Nullable
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");
            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

            /*Métodos do Nullable:

            *GetValueOrDefault: 
                        
            
            *HasValue:


            *Value:


            OBs: Um Nullable não pode ser atribuido a um struct comum

            */

        }
    }
}
