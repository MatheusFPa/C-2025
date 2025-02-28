using System;

namespace AreaTriangulo_ClassesAtributos_Metodos
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        //Prefixo de Acesso //Tipo de retorno //Nome do método(Função) //Parâmetros

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            // Ou  double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C)); --> Outra forma de escrever 
            //     return raiz;
        }
    }
}
