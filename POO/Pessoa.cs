using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public abstract class Pessoa
    {
        private string nome;
        private string nacionalidade;
        private string idade;

        public string Nome { get => nome; set => nome = value; }
        public string Nacionalidade { get => nacionalidade; set => nacionalidade = value; }
        public string Idade { get => idade; set => idade = value; }

        public virtual void caracteristica()
        {

        }
    }
}
