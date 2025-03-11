using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroBancoCorrigido
{
    class Cadastro
    {
        public int NumConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Cadastro(int numero, string titular)
        {
            NumConta = numero;
            Nome = titular;
            Saldo = 0.00;
        }

        public Cadastro(int numero, string titular, double _depositoInicial) : this(numero, titular)
        {
            Depositar(_depositoInicial);
        }

        public void Depositar(double quantia)
        {
            Saldo += quantia;
        }

        public void Sacar(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return ("Conta " + NumConta + ", Titular: " + Nome + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
