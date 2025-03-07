using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CotacaoDolar
{
    class ConversorMoeda
    {
        public static double Iof = 6.0;
        
        public static double DolarEmReal(double quant, double cotacao)
        {
            double total = quant * cotacao;

            return total + total * Iof / 100.00;
        }

      
    }
}
