using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDoRetangulo
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt((Math.Pow(Largura,2)) + (Math.Pow(Altura,2)));
        }
        public override string ToString()
        {
            return Area().ToString("F2", CultureInfo.InvariantCulture) + ", " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) + ", " + Diagonal().ToString("F2", CultureInfo.InvariantCulture) ;
        }
    }
}
