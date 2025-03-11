using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroBanco
{
    class Cadastro
    {
        //Atributos
        private string _nome;
        private string _depositoInicial;
        //Propriedade autoImplementada
        public int NumConta { get; private set; }
        public double Valor { get; private set; }

        //Construtor
        public Cadastro(int contaNum, string nome, string depositoInicial , double _valor)
        {
            _nome = nome;
            NumConta = contaNum;
            Valor = _valor;
            _depositoInicial = depositoInicial;
        }
        //Propriedade Customizada
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public string DepositoInicial
        {
            get { return _depositoInicial; }
            set
            {
                if (value != "s")
                {
                    _depositoInicial = "00.0";
                }
                else
                {
                    add(Valor);
                }
            }
        }

        //Métodos
        public void add(double _valor)
        {
             Valor = Valor + _valor;
        }
        public void Remover(double _valor)
        {
             Valor = Valor - _valor - 5;
        }
    }
}
