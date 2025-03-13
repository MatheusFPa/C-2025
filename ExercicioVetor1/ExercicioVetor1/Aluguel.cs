using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVetor1
{
    class Aluguel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        
        public Aluguel(string _nome, string _email)
        {
            Name = _nome;
            Email = _email;
         }

        public override string ToString()
        {
            return Name + ", " + Email;
        }

    }
}
