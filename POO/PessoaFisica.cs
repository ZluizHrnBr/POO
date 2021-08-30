using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class PessoaFisica: Pessoa
    {
        private string cpf;

        public string Cpf { get => cpf; set => cpf = value; }

        public override void caracteristica()
        {
            Console.WriteLine("O nome da pessoa é " + this.Nome);
            Console.WriteLine("o seu cpf é " + this.cpf);
            base.caracteristica();
        }
    }
}
