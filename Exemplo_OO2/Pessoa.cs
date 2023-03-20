using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_OO2
{
    internal class Pessoa
    {
        public string Nome{ get; set; }
        public string Telefone{ get; set; }

        public string Endereco { get; set; }

        public Pessoa(string nome, string tel, string end)
        {
            this.Nome = nome;
            this.Telefone = tel;
            this.Endereco = end;
        }

        public override string ToString()
        {
            return (Nome + " - " + Telefone + " - " + Endereco);
        }
    }
}
