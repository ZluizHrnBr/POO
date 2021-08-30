using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
  public abstract class Conta
    {
        private string nroConta;
        private string senha;
        private string bandeiraCartao;
        private double Saldo = 0.0;

        public string Senha { get => senha; set => senha = value; }
        public string BandeiraCartao { get => bandeiraCartao; set => bandeiraCartao = value; }
        public double Saldo1 { get => Saldo; set => Saldo = value; }
        public string NroConta { get => nroConta; set => nroConta = value; }

        public virtual bool Sacar(double sacar)
        {
            if(this.Saldo > 0.0)
            {
                this.Saldo = this.Saldo - sacar;
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool Depositar(double sacar)
        {
            this.Saldo = this.Saldo + sacar;
            return true;
        }

        public bool saldoAtual()
        {
            Console.WriteLine("O saldo atual " + this.Saldo1);
            return true;
        }
    }
}
