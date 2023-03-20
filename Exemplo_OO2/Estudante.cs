using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_OO2
{
    internal class Estudante : Pessoa
    {
        public int Matricula { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }

        public Estudante(string nome, string tel, string end, int ra) : base(nome, tel, end)
        {
            this.Matricula = ra;
        }

        public override string ToString()
        {
            return (base.ToString()+" - "+Matricula);
        }

        public double CalcularMedia(double n1, double n2)
        {
            this.Nota1 = n1;
            this.Nota2 = n2;
            return ((this.Nota1+this.Nota2)/2);
        }

        public double CalcularMedia(double n1, double n2, double peso1, double peso2)
        {
            this.Nota1 = n1;
            this.Nota2 = n2;
            return ((this.Nota1*(peso1/10))+(this.Nota2*(peso2/10)));
        }
    }
}
