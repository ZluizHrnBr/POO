using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pessoa = new PessoaFisica();
            ContaFísica conta = new ContaFísica();
            pessoa.Nome = "Lucas";
            conta.Saldo1 = 20000.0;
            conta.Sacar(5000.0);
            conta.saldoAtual();
        }
    }
}
