using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_OO2
{
    internal class Professor : Pessoa
    {
        public double Salario { get; set; }

        public Professor(string nome, string tel, string end, double salario) : base(nome, tel, end)
        {
            this.Salario = salario;
            
        }

        public Professor(Pessoa p, double salario) : base(p.Nome, p.Telefone, p.Telefone)
        {
            this.Salario = salario;
        }

        public override string ToString()
        {
            return (base.ToString()+" - "+Salario);
        }
    }
}
