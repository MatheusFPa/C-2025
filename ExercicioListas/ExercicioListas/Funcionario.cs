using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListas
{
    class Funcionario
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; private set; }
        
        public Funcionario(int id, string name, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public void AumentarSalario(double porcent)
        {
            Salary += Salary * porcent / 100.0;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
